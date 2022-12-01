using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSA_Lab4.Models
{
    public class MainRowModel : ViewModelBase
    {
        public static int count = 1;

        #region Properties
        int id;
        public int Id
        {
            get => id;
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        double x;
        public double X
        {
            get => x;
            set
            {
                x = value;
                OnPropertyChanged("X");
            }
        }

        double y;
        public double Y
        {
            get => y;
            set
            {
                y = value;
                OnPropertyChanged("Y");
            }
        }

        double xy;
        public double XY
        {
            get => xy;
            set
            {
                xy = value;
                OnPropertyChanged("XY");
            }
        }

        double powX;
        public double PowX
        {
            get => powX;
            set
            {
                powX = value;
                OnPropertyChanged("PowX");
            }
        }

        double powY;
        public double PowY
        {
            get => powY;
            set
            {
                powY = value;
                OnPropertyChanged("PowY");
            }
        }

        double xyByLinearRegression;
        public double XYByLinearRegression
        {
            get => xyByLinearRegression;
            set
            {
                xyByLinearRegression = value;
                OnPropertyChanged("XYByLinearRegression");
            }
        }

        double yMinusByLinearRegression;
        public double YMinusByLinearRegression
        {
            get => yMinusByLinearRegression;
            set
            {
                yMinusByLinearRegression = value;
                OnPropertyChanged("YMinusByLinearRegression");
            }
        }

        double approximationError;
        public double ApproximationError
        {
            get => approximationError;
            set
            {
                approximationError = value;
                OnPropertyChanged("ApproximationError");
            }
        }



        #endregion

        public MainRowModel(double x, double y)
        {
            Id = count;
            X = x;
            Y = y;
            XY = X * Y;
            PowX = Math.Pow(X, 2);
            PowY = Math.Pow(Y, 2);
            count++;
        }
        ~MainRowModel()
        {
            count--;
        }
    }
}
