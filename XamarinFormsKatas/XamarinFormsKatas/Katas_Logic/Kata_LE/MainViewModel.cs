using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinFormsKatas.Katas_Logic.Kata_LE
{
    public class MainViewModel:BindableObject
    {
        private byte? _rojo;
        public byte? rojo
        {
            get => _rojo;
            set
            {
                _rojo = value;
                OnPropertyChanged();
            }
        }
        private byte? _verde;
        public byte? verde
        {
            get => _verde;
            set
            {
                _verde = value;
                OnPropertyChanged();
            }
        }
        private byte? _azul;
        public byte? azul
        {
            get => _azul;
            set
            {
                _azul = value;
                OnPropertyChanged();
            }
        }
        private Color _colorMexcla;
        public Color colorMexcla
        {
            get => _colorMexcla;
            set
            {
                _colorMexcla = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            _mexclaColoresCommand = new Command(PerformBlendColors);
        }
        private Command _mexclaColoresCommand;
        public ICommand mexclaColoresCommand => _mexclaColoresCommand;
        private void PerformBlendColors(object obj)
        {
            if(_rojo.HasValue&& _verde.HasValue && _azul.HasValue)
            {
                colorMexcla = Color.FromRgb(_rojo.value, _verde.Value, _azul.Value);
            }
        }
    }
}
