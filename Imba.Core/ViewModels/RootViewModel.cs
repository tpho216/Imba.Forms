using System.Threading.Tasks;
using MvvmCross.ViewModels;

namespace Imba.Core.ViewModels
{
    public class RootViewModel : MvxViewModel
    {

        public RootViewModel()
        {
        }

        public override async Task Initialize()
        {
            await base.Initialize();

            SubTotal = 100;
            Generosity = 10;
            Recalculate();
        }

        private double _subTotal;
        public double SubTotal
        {
            get => _subTotal;
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);

                Recalculate();
            }
        }

        private int _generosity;
        public int Generosity
        {
            get => _generosity;
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);

                Recalculate();
            }
        }

        private double _tip;
        public double Tip
        {
            get => _tip;
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        private void Recalculate()
        {
        }
    }
}
