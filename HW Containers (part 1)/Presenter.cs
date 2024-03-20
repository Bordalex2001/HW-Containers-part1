using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Containers__part_1_
{
    internal class Presenter
    {
        private readonly IModel _model;
        private readonly IView _view;
        public Presenter(IModel model, IView view)
        {
           _model = model;
           _view = view;
           _view.IsCodeEntered += OnCodeEntered;
           _model.IsSafeOpened += OnSafeOpened;
        }
        public void CheckCode(string code)
        {
            if (_model.IsCodeCorrect(code))
            {
                _model.OnSafeOpened();
            }
            else
            {
                _view.DisplayMessage("Код невірний, уведіть ще раз!");
            }
        }
        private void OnCodeEntered(object sender, string code)
        {
            CheckCode(code);
        }
        private void OnSafeOpened(object sender, EventArgs e)
        {
            _view.DisplayMessage("Сейф відчинено!");
        }
    }
}