using Xamarin.Forms;

namespace HamburgerMenuExample {
	public partial class RootPage : MasterDetailPage {
		public RootPage() {
			InitializeComponent();
			MasterBehavior = MasterBehavior.Popover;
		}
	}
}

