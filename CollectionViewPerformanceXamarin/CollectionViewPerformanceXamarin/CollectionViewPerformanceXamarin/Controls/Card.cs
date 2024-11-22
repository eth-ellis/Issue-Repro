using Xamarin.Forms;

namespace CollectionViewPerformanceXamarin.Controls
{
	public class Card : Frame
	{
		public Card() : base()
		{
			this.IsClippedToBounds = true;

            this.BackgroundColor = Color.White;

			this.Padding = 15;

			this.HasShadow = false;
		}

		public static readonly BindableProperty HasCornerRadiusProperty = BindableProperty.Create(nameof(HasCornerRadius), typeof(bool), typeof(Card), false, BindingMode.OneTime, propertyChanged: (bindable, oldValue, newValue) =>
		{
			if ((bool)newValue)
			{
				((Card)bindable).CornerRadius = 15;
			}
		});

        public bool HasCornerRadius
		{
			get => (bool)GetValue(HasCornerRadiusProperty);
			set => SetValue(HasCornerRadiusProperty, value);
		}
    }
}