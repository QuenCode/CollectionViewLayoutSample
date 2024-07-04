using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiCollectionViewLayout.DataModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCollectionViewLayout.PageViewModels
{
    public partial class MyTestPageViewModel : ObservableObject
    {
        #region Properties
        [ObservableProperty]
        private ObservableCollection<Scale> scaleList;
        [ObservableProperty]
        private int maxRowCount;
        [ObservableProperty]
        private string feedbackText;
        #endregion



        #region Constructors
        public MyTestPageViewModel()
        {
            ScaleList = new ObservableCollection<Scale>();
            FeedbackText = "Some Footer";

            for (int s = 0; s < 7; s++)
            {
                Scale scale = new Scale();
                scale.Label = $"Scale {s}";

                for (int v = 0; v < 3+s; v++)
                {
                    MyValue myValue = new MyValue();
                    myValue.Name = $"Value {s} - {v}";
                    myValue.Value = s+v;
                    scale.ValueList.Add(myValue);
                }
                if (s == 0)
                {
                    for (int v = 3; v < 6; v++)
                    {
                        MyValue myValue = new MyValue();
                        myValue.Name = $"Value {s} - {v}";
                        myValue.Value = s + v;
                        scale.ValueList.Add(myValue);
                    }
                }

                ScaleList.Add(scale);
            }

            MaxRowCount = GetHighestRowCountOfColumns(ScaleList);
        }
        #endregion



        #region RelayCommands
        [RelayCommand]
        private void ValuePressed(MyValue selectedValue)
        {
            FeedbackText = $"Selected value: {selectedValue.Value}";
        }
        #endregion


        #region Methods
        private int GetHighestRowCountOfColumns(ObservableCollection<Scale> allScales)
        {
            int maxCount = 0;
            foreach (Scale scale in allScales)
            {
                if(scale.ValueList.Count > maxCount)
                    maxCount = scale.ValueList.Count;
            }
            return maxCount;
        }
        #endregion
    }
}
