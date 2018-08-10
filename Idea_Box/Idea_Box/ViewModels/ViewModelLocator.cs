using CommonServiceLocator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Idea_Box.ViewModels
{
   public class ViewModelLocator
    {

        public IdeaViewModel IdeaViewModel
        {
            get
            {
                return ServiceLocator.Current.GetInstance<IdeaViewModel>();
            }
          

        }

    }
}
