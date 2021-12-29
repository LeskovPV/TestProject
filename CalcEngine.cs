using System;
using System.Collections.Generic;

namespace TestProject
{
    internal class CalcEngine
    {
        // Индексы искомых и промежуточных переменных (P,Q и W), используются в качестве ключей
        private List<char> keys = new List<char> { 'x', 'y', 'n', 'z' };
        public List<char> getKeys() { return keys; }

        // Вероятности исходов, рассчитанные прямым подходом
        // Формируется методом Calculate()
        private Dictionary<char, double> P = new Dictionary<char, double>();
        public Dictionary<char, double> getP() { return P; }

        // Вероятности исходов, рассчитанные методом Монте-Карло
        // Описан методом Verification(). Всегда вызывается после расчёта Calculate()
        private Dictionary<char, double> Q = new Dictionary<char, double>();
        public Dictionary<char, double> getQ() { return Q; }

        // Cтатистика по данным предыдущих встреч
        private double[,] Pxy = new double[7, 6] {
            {4.33,   6.05,   4.24,   1.98,   0.7,    0.19 },
            {7.57,   10.59,  7.41,   3.46,   1.21,   0.34 },
            {6.62,   9.27,   6.48,   3.03,   1.06,   0.29 },
            {3.86,   5.41,   3.78,   1.76,   0.62,   0.17 },
            {1.68,   2.36,   1.65,   0.78,   0.27,   0.00 },
            {0.59,   0.83,   0.57,   0.27,   0.00,   0.00 },
            {0.17,   0.24,   0.17,   0.00,   0.00,   0.00 }
        };

        public double[,] getPxy() { return Pxy;  }
        public double getPxy(int x, int y) { return Pxy[x,y]; }
        // Максимальное количество голов, забитых командой "Хозяева" в статистике
        public int getNx() { return Pxy.GetLength(0); }
        // Максимальное количество голов, забитых командой "Гости" в статистике
        public int getNy() { return Pxy.GetLength(1); }
        private void setPxy(double[,] _Pxy)
        {
            int Nx = _Pxy.GetLength(0);
            int Ny = _Pxy.GetLength(1);
            Pxy = new double[Nx, Ny];
            for (int x = 0; x < Nx; x++)
                for (int y = 0; y < Ny; y++)
                    Pxy[x, y] = _Pxy[x, y];
            // Нормирование 
            double sum = 0;
            for (int x = 0; x < Nx; x++)
                for (int y = 0; y < Ny; y++)
                    sum += Pxy[x, y];
            if (Math.Abs(sum - 1) < 0.001)
            {
                sum = Nx * Ny;
                for (int x = 0; x < Nx; x++)
                    for (int y = 0; y < Ny; y++)
                        Pxy[x, y] = 1 / sum;
            }
            else
            {
                for (int x = 0; x < Nx; x++)
                    for (int y = 0; y < Ny; y++)
                        Pxy[x, y] = Pxy[x, y] / sum;
            }

        }

        // Список забитых голов: 1 - забили "Хозяева", -1 - забили "Гости"
        private int[] G;

        // Минут до конца матча
        private double T = 60.0;

        // Начало интервала
        private int kb;

        // Конец интервала
        private int ke;

        // Количество итераций
        private int N;

        // Распределение количества забитых голов командой "Хозяева" за T минут до конца матча
        private double[] Px;

        // Распределение количества забитых голов командой "Гости" за T минут до конца матча
        private double[] Py;

        private Random random = new Random();

        public CalcEngine()
        {
            setPxy(Pxy); // Нормируем (из %% в доли вероятности)
            foreach (char key in keys)
            {
                P.Add(key, 0);  Q.Add(key, 0); 
            }
        }

        // Факториал n
        private double factorialFunc(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            return result;
        }

        // Функция Пуассона
        private double poissonFunc(int k, double l)
        {
            return Math.Exp(-l) * Math.Pow(l, k) / factorialFunc(k);
        }

        public bool calculate(double[,] _Pxy, int[] _G, double _T, int _kb, int _ke, int _N) 
        {
            setPxy(_Pxy);
            int Nx = getNx();
            int Ny = getNy();

            int kt = _G.Length - 1;
            G = new int[kt + 1];
            _G.CopyTo(G, 0);

            T = _T;
            kb = _kb < _ke ? _kb : _ke;
            ke = _kb < _ke ? _ke : _kb;
            // Начинаем расчёт c lambda
            double lx = 0, ly = 0;
            for (int x = 0; x < Nx; x++)
                for (int y = 0; y < Ny; y++)
                {
                    lx += x * Pxy[x, y];
                    ly += y * Pxy[x, y];
                }

            // Дельта забитых голов от начала интервала до текущего момента
            int d = 0;
            if (kb <= kt)
                for (int k = kb; k <= Math.Min(ke, kt); k++)
                    d += G[k];

            if (ke <= kt)
            {   // Если события интервала уже произошли, то
                P['x'] = d > 0 ? 1 : 0;
                P['n'] = d == 0 ? 1 : 0;
                P['y'] = d < 0 ? 1 : 0;
                P['z'] = 0;
            }
            else
            {
                double dt = 90 / (lx + ly); //среднее время на один гол
                if (dt * (ke - kt) < T)
                    T = dt * (ke - kt);
                    lx *= (double)T / 90.0;
                ly *= (double)T / 90.0;
                // Подготовка по-командных распределений голов
                Px = new double[Nx];
                Py = new double[Ny];
                for (int k = 0; k < Nx; k++)
                    Px[k] = poissonFunc(k, lx);
                for (int k = 0; k < Ny; k++)
                    Py[k] = poissonFunc(k, ly);
                // Инициализация
                foreach (char key in keys)
                    P[key] = 0;
                double p;
                for (int kx = 0; kx < Nx; kx++)
                    for (int ky = 0; ky < Ny; ky++)
                    {
                        p = Px[kx] * Py[ky];
                        if (kx + ky < ke - kt) // Интервал не закрыт
                        {
                            P['z'] += p;
                            continue;
                        }
                        P['x'] += (kx + d) > ky ? p : 0;
                        P['y'] += (kx + d) < ky ? p : 0;
                        if ((kx + d) == ky) // Если счёт равный
                        {
                            if (((ke - kb + 1) % 2) == 0)          // При чётном интервале
                                P['n'] += (kx + d) == ky ? p : 0;  // зачитываем ничью, 
                            else                                   // в противном случае
                            {                                      // одна из команд побеждает с вероятность 1/2
                                P['x'] += p / 2;
                                P['y'] += p / 2;
                            }
                        }
                    }
            }
            verification(_N);
            return true; 
        }

        // Метод Монте-Карло (Monte Carlo method) 
        // по расчитанной моделе генерирует случайные исходы N раз и формирует статистику Q
        public bool verification(int _N = 100)
        {
            N = _N;
            int Nx = Px.Length;
            int Ny = Py.Length;
            if (Nx * Ny == 0)
                return false;
            int d = 0;
            int kt = G.Length - 1;
            // Cтатистика количества исходов
            Dictionary<char, double> W = new Dictionary<char, double>();
            foreach (char key in keys)
                W.Add(key, 0);
            // Получаем функцию распределения sPx из функции плотности вероятности Px
            double[] sPx = new double[Nx];
            sPx[0] = Px[0];
            for (int k = 1; k < Nx; k++)
                sPx[k] = Px[k] + sPx[k - 1];
            // Получаем функцию распределения sPx из функции плотности вероятности Px
            double[] sPy = new double[Ny];
            sPy[0] = Py[0];
            for (int k = 1; k < Ny; k++)
                sPy[k] = Py[k] + sPy[k - 1];
            // Дельта забитых голов от начала интервала до текущего момента
            if (kb <= kt)
                for (int k = kb; k <= Math.Min(ke, kt); k++)
                    d += G[k];
            double randomValue;
            int kx = 0; // Количество голов забитых командой "Хозяева" за T минут до конца матча
            int ky = 0; // Количество голов забитых командой "Гости" за T минут до конца матча
            for (int i = 0; i < N; i++)
            {
                randomValue = random.NextDouble();
                for (int k = 0; k < Nx; k++)
                    if (randomValue < sPx[k])
                    {
                        kx = k;
                        break;
                    }
                randomValue = random.NextDouble();
                for (int k = 0; k < Ny; k++)
                    if (randomValue < sPy[k])
                    {
                        ky = k;
                        break;
                    }
                if (kx + ky < ke - kt) // Интервал не закрыт
                    W['z'] += 1;
                else
                {
                    W['x'] += (kx + d) > ky ? 1 : 0;
                    W['y'] += (kx + d) < ky ? 1 : 0;
                    if ((kx + d) == ky)
                    {
                        if (((ke - kb + 1) % 2) == 0) // При чётном интервале
                            W['n'] += 1;              // зачитываем ничью, 
                        else                          // в противном случае
                        {                             // одна из команд побеждает с вероятность 1/2
                            W['x'] += 0.5;          
                            W['y'] += 0.5;
                        }
                    }
                }
            }
            // Расчитываем вероятности исходов
            foreach (char key in keys)
                 Q[key] = W[key] / N;
            return true;
        }

    }
}
