using LiveCharts;
using LiveCharts.Defaults;
using OSA_Lab4.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace OSA_Lab4.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public ObservableCollection<MainRowModel> MainRows { get; set; }

        public ChartValues<ObservablePoint> ActualValues { get; set; }

        public ChartValues<ObservablePoint> PredictedValues { get; set; }

        public ChartValues<ObservablePoint> TheoreticalValues { get; set; }

        #region Properties
        double b1Coefficient;
        public double B1Coefficient
        {
            get => b1Coefficient;
            set
            {
                b1Coefficient = value;
                OnPropertyChanged("B1Coefficient");
            }
        }
        double b0Coefficient;
        public double B0Coefficient
        {
            get => b0Coefficient;
            set
            {
                b0Coefficient = value;
                OnPropertyChanged("B0Coefficient");
            }
        }

        double sigmaX;
        public double SigmaX
        {
            get => sigmaX;
            set
            {
                sigmaX = value;
                OnPropertyChanged("SigmaX");
            }
        }
        double sigmaY;
        public double SigmaY
        {
            get => sigmaY;
            set
            {
                sigmaY = value;
                OnPropertyChanged("SigmaY");
            }
        }

        double correlationCoefficient;
        public double CorrelationCoefficient
        {
            get => correlationCoefficient;
            set
            {
                correlationCoefficient = value;
                OnPropertyChanged("CorrelationCoefficient");
            }
        }
        double powCorrelationCoefficient;
        public double PowCorrelationCoefficient
        {
            get => powCorrelationCoefficient;
            set
            {
                powCorrelationCoefficient = value;
                OnPropertyChanged("PowCorrelationCoefficient");
            }
        }

        double qualityModelbyAverageApproximation;
        public double QualityModelbyAverageApproximation
        {
            get => qualityModelbyAverageApproximation;
            set
            {
                qualityModelbyAverageApproximation = value;
                OnPropertyChanged("QualityModelbyAverageApproximation");
            }
        }

        string stringqualityModelbyAverageApproximation;
        public string StringQualityModelbyAverageApproximation
        {
            get => stringqualityModelbyAverageApproximation;
            set
            {
                stringqualityModelbyAverageApproximation = value;
                OnPropertyChanged("StringQualityModelbyAverageApproximation");
            }
        }

        string stringCorrelation;
        public string StringCorrelation
        {
            get => stringCorrelation;
            set
            {
                stringCorrelation = value;
                OnPropertyChanged("StringCorrelation");
            }
        }

        double fishersCriterion;
        public double FishersCriterion
        {
            get => fishersCriterion;
            set
            {
                fishersCriterion = value;
                OnPropertyChanged("FishersCriterion");
            }
        }

        double tableTCriterion;
        public double TableTCriterion
        {
            get => tableTCriterion;
            set
            {
                tableTCriterion = value;
                OnPropertyChanged("TableTCriterion");
            }
        }

        double sOst;
        public double SOst
        {
            get => sOst;
            set
            {
                sOst = value;
                OnPropertyChanged("SOst");
            }
        }

        double maError;
        public double MaError
        {
            get => maError;
            set
            {
                maError = value;
                OnPropertyChanged("MaError");
            }
        }

        double mbError;
        public double MbError
        {
            get => mbError;
            set
            {
                mbError = value;
                OnPropertyChanged("MbError");
            }
        }

        double mCorrelationError;
        public double MCorrelationError
        {
            get => mCorrelationError;
            set
            {
                mCorrelationError = value;
                OnPropertyChanged("MCorrelationError");
            }
        }

        double taCoefficient;
        public double TaCoefficient
        {
            get => taCoefficient;
            set
            {
                taCoefficient = value;
                OnPropertyChanged("TaCoefficient");
            }
        }

        double tbCoefficient;
        public double TbCoefficient
        {
            get => tbCoefficient;
            set
            {
                tbCoefficient = value;
                OnPropertyChanged("TbCoefficient");
            }
        }

        double tCorrelationCoefficient;
        public double TCorrelationCoefficient
        {
            get => tCorrelationCoefficient;
            set
            {
                tCorrelationCoefficient = value;
                OnPropertyChanged("TCorrelationCoefficient");
            }
        }

        string stringTResult;
        public string StringTResult
        {
            get => stringTResult;
            set
            {
                stringTResult = value;
                OnPropertyChanged("StringTResult");
            }
        }
        double predictT;
        public double PredictT
        {
            get => predictT;
            set
            {
                predictT = value;
                OnPropertyChanged("PredictT");
            }
        }
        double predictValue;
        public double PredictValue
        {
            get => predictValue;
            set
            {
                predictValue = value;
                OnPropertyChanged("PredictValue");
            }
        }

        double predictError;
        public double PredictError
        {
            get => predictError;
            set
            {
                predictError = value;
                OnPropertyChanged("PredictError");
            }
        }

        double marginalPredictError;
        public double MarginalPredictError
        {
            get => marginalPredictError;
            set
            {
                marginalPredictError = value;
                OnPropertyChanged("MarginalPredictError");
            }
        }

        double minPredictValue;
        public double MinPredictValue
        {
            get => minPredictValue;
            set
            {
                minPredictValue = value;
                OnPropertyChanged("MinPredictValue");
            }
        }

        double maxPredictValue;
        public double MaxPredictValue
        {
            get => maxPredictValue;
            set
            {
                maxPredictValue = value;
                OnPropertyChanged("MaxPredictValue");
            }
        }

        double minTaValue;
        public double MinTaValue
        {
            get => minTaValue;
            set
            {
                minTaValue = value;
                OnPropertyChanged("MinTaValue");
            }
        }

        double maxTaValue;
        public double MaxTaValue
        {
            get => maxTaValue;
            set
            {
                maxTaValue = value;
                OnPropertyChanged("MaxTaValue");
            }
        }

        double minTbValue;
        public double MinTbValue
        {
            get => minTbValue;
            set
            {
                minTbValue = value;
                OnPropertyChanged("MinTbValue");
            }
        }

        double maxTbValue;
        public double MaxTbValue
        {
            get => maxTbValue;
            set
            {
                maxTbValue = value;
                OnPropertyChanged("MaxTbValue");
            }
        }

        double marginalTaError;
        public double MarginalTaError
        {
            get => marginalTaError;
            set
            {
                marginalTaError = value;
                OnPropertyChanged("MarginalTaError");
            }
        }

        double marginalTbError;
        public double MarginalTbError
        {
            get => marginalTbError;
            set
            {
                marginalTbError = value;
                OnPropertyChanged("MarginalTbError");
            }
        }



        #endregion

        #region Enums

        public enum ModelQuality
        {
            Excellent,
            Good,
            Bad
        }

        public enum Correlation
        {
            VeryTight,
            Tight,
            Notable,
            Mild,
            Weak
        }

        public enum TResult
        {
            NotImportant,
            Important,
        }


        readonly Dictionary<ModelQuality, String> ModelQualitys = new Dictionary<ModelQuality, string>
        {
            {ModelQuality.Excellent,"Отличное" },
            {ModelQuality.Good,"Хорошее" },
            {ModelQuality.Bad,"Плохое" }
        };

        readonly Dictionary<Correlation, String> CorrelationValues = new Dictionary<Correlation, string>
        {
            {Correlation.VeryTight,"Весьма тесная" },
            {Correlation.Tight,"Тесная" },
            {Correlation.Notable,"Заметная" },
            {Correlation.Mild,"Умеренная " },
            {Correlation.Weak,"Слабая" }
        };

        readonly Dictionary<TResult, String> TStringResults = new Dictionary<TResult, string>
        {
            {TResult.NotImportant,"Параметры случайны и статистически не значимы." },
            {TResult.Important,"Параметры не случайно отличаются от нуля, а статистически значимы." },
        };

        #endregion

        #region Commands
        private ICommand calculateCommand;
        public ICommand CalculateCommand
        {
            get
            {
                if (calculateCommand == null)
                {
                    calculateCommand = new RelayCommand(
                        param => this.Calculate()
                    );
                }
                return calculateCommand;
            }
        }

        private ICommand predictCommand;
        public ICommand PredictCommand
        {
            get
            {
                if (predictCommand == null)
                {
                    predictCommand = new RelayCommand(
                        param => this.Predict()
                    );
                }
                return predictCommand;
            }
        }
        #endregion


        public void Calculate()
        {
            if (MainRows.Count() == 0)
            {
                MessageBox.Show("Количество строк должно быть больше 0","Ошибка");
                return;
            }
            if (TableTCriterion == 0)
            {
                MessageBox.Show("Необходимо ввести табличное значение t критерия", "Ошибка");
                return;
            }
            ClearAll();
            CalculateAnalyticalAligmentOfSeriesDynamicsInAStraightLine();
            CalculateYMinusByLinearRegression();
            CalculateApproximationError();
            CalculateCorrelationCoefficient();
            CalculateFishersCriterion();
            CalculateTDistribution();
            DrawMainChart();
            DrawTheoreticalLine();
        }

        public void ClearAll()
        {
            ActualValues.Clear();
            TheoreticalValues.Clear();
            PredictedValues.Clear();
        }

        #region Draw
        public void DrawMainChart()
        {
            foreach (var item in MainRows)
            {
                ActualValues.Add(new ObservablePoint(item.X, item.Y));
            }
        }

        public void DrawTheoreticalLine()
        {
            foreach (var item in MainRows)
            {
                TheoreticalValues.Add(new ObservablePoint(item.X, item.XYByLinearRegression));
            }
        }
        #endregion
        public void CalculateAnalyticalAligmentOfSeriesDynamicsInAStraightLine()
        {
            B1Coefficient = (MainRows.Select(x => x.XY).Average() - MainRows.Select(x => x.X).Average() * MainRows.Select(x => x.Y).Average()) / (MainRows.Select(x => x.PowX).Average() - Math.Pow(MainRows.Select(x => x.X).Average(), 2));
            B0Coefficient = MainRows.Select(x => x.Y).Average() - (B1Coefficient * MainRows.Select(x => x.X).Average());
            foreach (var item in MainRows)
            {
                item.XYByLinearRegression = B0Coefficient + B1Coefficient * item.X;
            }
        }

        public void CalculateApproximationError()
        {
            foreach (var item in MainRows)
            {
                item.ApproximationError = Math.Abs(item.YMinusByLinearRegression) / item.Y;
            }
            QualityModelbyAverageApproximation = MainRows.Average(x => x.ApproximationError);

            StringQualityModelbyAverageApproximation = ModelQualitys[ModelQuality.Bad];
            if (QualityModelbyAverageApproximation*100 < 10) StringQualityModelbyAverageApproximation = ModelQualitys[ModelQuality.Good];
            if (QualityModelbyAverageApproximation*100 < 1) StringQualityModelbyAverageApproximation = ModelQualitys[ModelQuality.Excellent];
        }

        public void CalculateYMinusByLinearRegression()
        {
            foreach (var item in MainRows)
            {
                item.YMinusByLinearRegression = item.Y - item.XYByLinearRegression;
            }
        }


        public void CalculateCorrelationCoefficient()
        {
            SigmaX = Math.Sqrt(MainRows.Average(x => x.XY) - MainRows.Average(x => x.X) * MainRows.Average(x => x.Y));
            SigmaY = Math.Sqrt(Math.Sqrt(MainRows.Average(x => x.PowX) - Math.Pow(MainRows.Average(x => x.X),2)) * Math.Sqrt(MainRows.Average(x => x.PowY) - Math.Pow(MainRows.Average(x => x.Y), 2)));
            CorrelationCoefficient = B1Coefficient * SigmaX / SigmaY;
            PowCorrelationCoefficient = Math.Pow(CorrelationCoefficient, 2);

            StringCorrelation = CorrelationValues[Correlation.VeryTight];
            if (CorrelationCoefficient < 0.9) StringCorrelation = CorrelationValues[Correlation.Tight];
            if (CorrelationCoefficient < 0.7) StringCorrelation = CorrelationValues[Correlation.Notable];
            if (CorrelationCoefficient < 0.5) StringCorrelation = CorrelationValues[Correlation.Mild];
            if (CorrelationCoefficient < 0.3) StringCorrelation = CorrelationValues[Correlation.Weak];
        }

        public void CalculateFishersCriterion()
        {
            FishersCriterion = PowCorrelationCoefficient / (1 - PowCorrelationCoefficient) * (MainRows.Count()-2); 
        }

        public void CalculateTDistribution()
        {
            SOst = Math.Sqrt(MainRows.Sum(x=>Math.Pow(x.YMinusByLinearRegression,2))/MainRows.Count()-2);
            MaError = SOst * (Math.Sqrt(MainRows.Sum(x => x.PowX)) / (MainRows.Count() * SigmaX));
            MbError = SOst / (SigmaX * Math.Sqrt(MainRows.Count()));
            MCorrelationError = Math.Sqrt((1-PowCorrelationCoefficient)/(MainRows.Count()-2));

            TaCoefficient = B0Coefficient / MaError;
            TbCoefficient = B1Coefficient / MbError;
            TCorrelationCoefficient = CorrelationCoefficient / MCorrelationError;

            MarginalTaError = TableTCriterion * MaError;
            MarginalTbError = TableTCriterion * MbError;

            MinTaValue = B0Coefficient - MarginalTaError;
            MaxTaValue = B0Coefficient + MarginalTaError;

            MinTbValue = B1Coefficient - MarginalTbError;
            MaxTbValue = B1Coefficient + MarginalTbError;


            StringTResult = (TaCoefficient > TableTCriterion && TbCoefficient > TableTCriterion && TCorrelationCoefficient > TableTCriterion) ? TStringResults[TResult.Important] : TStringResults[TResult.NotImportant];
        }

        /// <summary>
        /// Прогнозирование новых данных
        /// </summary>
        public void Predict()
        {
            if (B0Coefficient == 0 || B1Coefficient == 0)
            {
                MessageBox.Show("Сначала необходимо сделать рассчет");
                return;
            }
            PredictValue = B0Coefficient + B1Coefficient * predictT;
            PredictError = SOst * Math.Sqrt(1 + (1 / MainRows.Count()) + (Math.Pow(PredictT - MainRows.Average(x => x.X), 2) / (MainRows.Sum(x => Math.Pow(x.X - MainRows.Average(y => y.X), 2)))));
            MarginalPredictError = TableTCriterion * PredictError;
            MinPredictValue = PredictValue - MarginalPredictError;
            MaxPredictValue = PredictValue + MarginalPredictError;
            PredictedValues.Add(new ObservablePoint(predictT, PredictValue));
        }




        public MainViewModel()
        {
            ActualValues = new ChartValues<ObservablePoint>();
            PredictedValues = new ChartValues<ObservablePoint>();
            TheoreticalValues = new ChartValues<ObservablePoint>();
            TableTCriterion = 2.23;
            MainRows = new ObservableCollection<MainRowModel>
            {
                new MainRowModel(78,133),
                new MainRowModel(82,148),
                new MainRowModel(87,134),
                new MainRowModel(79,154),

                new MainRowModel(89,162),
                new MainRowModel(106,195),
                new MainRowModel(67,139),
                new MainRowModel(88,158),

                new MainRowModel(73,152),
                new MainRowModel(87,162),
                new MainRowModel(76,159),
                new MainRowModel(115,173),
            };
        }
    }
}
