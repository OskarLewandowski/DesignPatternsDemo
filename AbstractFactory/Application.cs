using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Application
    {
        private IUIElementFactory _UIElementFactory;

        public Application(IUIElementFactory uIElementFactory)
        {
            _UIElementFactory = uIElementFactory;
        }

        public void RenderUI()
        {
            var createNewFileButton = _UIElementFactory.CreateButton();
            createNewFileButton.Render();
            createNewFileButton.HandleClick();

            var createNewTextBox = _UIElementFactory.CreateTextBox();
            createNewTextBox.Render();
            createNewTextBox.HandleClick();
        }
    }
}
