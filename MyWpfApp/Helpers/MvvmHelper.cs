namespace MyWpfApp.Helpers
{
    using System.Windows;

    internal static class MvvmHelper
    {
        /// <summary>
        /// The show.
        /// </summary>
        /// <param name="viewModel">
        /// The view model.
        /// </param>
        /// <param name="title">
        /// The title.
        /// </param>
        /// <param name="width">
        /// The width.
        /// </param>
        /// <param name="height">
        /// The height.
        /// </param>
        /// <param name="left">
        /// The left.
        /// </param>
        /// <param name="top">
        /// The top.
        /// </param>
        /// <param name="minHeight">
        /// The min Height.
        /// </param>
        /// <param name="minWidth">
        /// The min Width.
        /// </param>
        /// <param name="startupLocation">
        /// The startup Location.
        /// </param>
        /// <param name="maxHeight">
        /// The max Height.
        /// </param>
        /// <param name="maxWidth">
        /// The max Width.
        /// </param>
        /// <param name="resizeMode">
        /// The resize Mode.
        /// </param>
        /// <param name="removeWindowButtons">
        /// The remove Window Buttons.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        public static void Show<T>(
            this T viewModel,
            string title = null,
            double? width = null,
            double? height = null,
            double? left = null,
            double? top = null,
            double? minHeight = null,
            double? minWidth = null,
            WindowStartupLocation? startupLocation = null,
            double? maxHeight = null,
            double? maxWidth = null,
            ResizeMode? resizeMode = null)
            where T : BaseVm
        {
            var window = InitWindow(
                viewModel,
                title,
                width,
                height,
                left,
                top,
                minHeight,
                minWidth,
                startupLocation,
                maxHeight,
                maxWidth,
                resizeMode);
            window.Show();
        }

        /// <summary>
        /// The show dialog.
        /// </summary>
        /// <param name="viewModel">
        /// The view model.
        /// </param>
        /// <param name="title">
        /// The title.
        /// </param>
        /// <param name="width">
        /// The width.
        /// </param>
        /// <param name="height">
        /// The height.
        /// </param>
        /// <param name="left">
        /// The left.
        /// </param>
        /// <param name="top">
        /// The top.
        /// </param>
        /// <param name="minHeight">
        /// The min height.
        /// </param>
        /// <param name="minWidth">
        /// The min width.
        /// </param>
        /// <param name="startupLocation">
        /// The startup location.
        /// </param>
        /// <param name="maxHeight">
        /// The max height.
        /// </param>
        /// <param name="maxWidth">
        /// The max width.
        /// </param>
        /// <param name="resizeMode">
        /// The resize Mode.
        /// </param>
        /// <param name="removeWindowButtons">
        /// The remove Window Buttons.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        /// <returns>
        /// The <see cref="bool?"/>.
        /// </returns>
        public static bool? ShowDialog<T>(
            this T viewModel,
            string title = null,
            double? width = null,
            double? height = null,
            double? left = null,
            double? top = null,
            double? minHeight = null,
            double? minWidth = null,
            WindowStartupLocation? startupLocation = null,
            double? maxHeight = null,
            double? maxWidth = null,
            ResizeMode? resizeMode = null)
            where T : BaseVm
        {
            var window = InitWindow(
                viewModel,
                title,
                width,
                height,
                left,
                top,
                minHeight,
                minWidth,
                startupLocation,
                maxHeight,
                maxWidth,
                resizeMode);

            window.ShowDialog();
            return window.DialogResult;
        }

        /// <summary>
        /// The init window.
        /// </summary>
        /// <param name="vm">
        /// The vm.
        /// </param>
        /// <param name="title">
        /// The title.
        /// </param>
        /// <param name="width">
        /// The width.
        /// </param>
        /// <param name="height">
        /// The height.
        /// </param>
        /// <param name="left">
        /// The left.
        /// </param>
        /// <param name="top">
        /// The top.
        /// </param>
        /// <param name="minHeight">
        /// The min height.
        /// </param>
        /// <param name="minWidth">
        /// The min width.
        /// </param>
        /// <param name="startupLocation">
        /// The startup location.
        /// </param>
        /// <param name="maxHeigh">
        /// The max heigh.
        /// </param>
        /// <param name="maxWidth">
        /// The max width.
        /// </param>
        /// <param name="resizeMode">
        /// The resize Mode.
        /// </param>
        /// <param name="removeWindowButtons">
        /// The remove Window Buttons.
        /// </param>
        /// <returns>
        /// The <see cref="Window"/>.
        /// </returns>
        private static Window InitWindow(
            BaseVm vm,
            string title,
            double? width,
            double? height,
            double? left,
            double? top,
            double? minHeight,
            double? minWidth,
            WindowStartupLocation? startupLocation,
            double? maxHeigh,
            double? maxWidth,
            ResizeMode? resizeMode)
        {
            var window = new Window();
            if (!string.IsNullOrEmpty(title)) window.Title = title;
            window.Content = vm;
            window.Closing += vm.OnClosing;

            if (width.HasValue) window.Width = width.Value;
            if (height.HasValue) window.Height = height.Value;

            if (left.HasValue) window.Left = left.Value;
            if (top.HasValue) window.Top = top.Value;

            if (minHeight.HasValue) window.MinHeight = minHeight.Value;
            if (minWidth.HasValue) window.MinWidth = minWidth.Value;

            if (startupLocation.HasValue) window.WindowStartupLocation = startupLocation.Value;
            if (maxHeigh.HasValue) window.MaxHeight = maxHeigh.Value;
            if (maxWidth.HasValue) window.MaxWidth = maxWidth.Value;
            if (resizeMode.HasValue) window.ResizeMode = resizeMode.Value;

            return window;
        }
    }
}