using System;
using System.Drawing;

namespace General.Shapes
{
    /// <summary>  
    /// Represents a rectangle.
    /// </summary>
    public class Rectangle : GeometricShape
    {
        private decimal height;
        private decimal width;

        /// <summary>
        /// Initializes an instance of a rectangle shape with a height and width of 1 that is filled white in color.
        /// </summary>
        public Rectangle() : this(1, 1)
        {
        }

        /// <summary>
        /// Initializes an instance of a rectangle shape with a given height and width that is filled white in color.
        /// </summary>
        /// <param name="height">The height of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when specifying a height or width lesser than or equal to 0.
        /// </exception>
        public Rectangle(decimal height, decimal width) : this(height, width, Color.White, true)
        {
        }

        /// <summary>
        /// Initializes an instance of a rectangle shape with a given height, width, color and whether its filled or not.
        /// </summary>
        /// <param name="height">The height of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="color">The color of the rectangle.</param>
        /// <param name="isFilled">The filled state of the rectangle - Filled or not.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when specifying height or width lesser than or equal to 0.
        /// </exception>
        public Rectangle(decimal height, decimal width, string color, bool isFilled) : base(color, isFilled)
        {
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException("height","Height cannot be lesser than or equal to 0");
            }

            if (width <= 0)
            {
                throw new ArgumentOutOfRangeException("width", "Width cannot be lesser than or equal to 0");
            }


            this.height = height;
            this.width = width;
        }

        /// <summary>
        /// Gets and sets the height of the rectangle.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when height is set to a value lesser than or equal to 0.</exception>
        public decimal Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value","Height cannot be lesser than or equal to 0");
                }
                               
                this.height = value;               
            }
        }

        /// <summary>
        /// Gets and sets the width of the rectangle.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when width is set to a value lesser than or equal to 0.</exception>
        public decimal Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value","Width cannot be lesser than or equal to 0");
                }
            }
        }

        /// <summary>
        /// Gets the area of the rectangle.
        /// </summary>
        public override decimal Area
        {
            get
            {
                return (this.Height * this.Width);
            }
        }

        /// <summary>
        /// Gets the perimeter of the rectangle.
        /// </summary>
        public override decimal Perimeter
        {
            get
            {
                return 2.0M * (this.height + this.Width);
            }
        }

        /// <summary>
        /// Returns a string representation of the rectangle.
        /// </summary>
        /// <returns>String representation of the rectangle.</returns>
        public override string ToString()
        {
            return base.ToString() + $"\nHeight: {this.Height}      Width: {this.Width}     Area: {this.Area}       " +
            $"Perimeter: { this.Perimeter}";
        }
    }
}
