#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System;
using System.Windows.Controls;
#endif

namespace MultiplayerGame
{
    /// <summary>
    /// Interaction logic for MultiplayerGameMainView.xaml
    /// </summary>
    public partial class HUD : UserControl
    {
        public HUD()
        {
            InitializeComponent();
        }

#if NOESIS
        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this);
        }
#endif
    }
}
