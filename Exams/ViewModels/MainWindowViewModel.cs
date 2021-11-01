using Exams.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.ViewModels
{
    internal class MainWindowViewModel : BaseViewModel
    {
        #region Заголовок главного окна
        /// <summary>
        /// Заголовок главного окна
        /// </summary>
        private string _Title = "Даты экзаменов";
        /// <summary>
        /// Заголовок главного окна
        /// </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion
    }
}
