using System;

namespace General.Shapes
{
    /// <summary>
    /// Represents a generalized geometric shape.
    /// </summary>
    public abstract class GeometricShape
    {
        private string color;
        private bool isFilled;

        /// <summary>
        /// Initializes an instance of a geometric shape with a given color and whether if its filled or not.
        /// </summary>
        /// <param name="color">The color of the shape.</param>
        /// <param name="isFilled">If the shape is filled or not.</param>
        /// <exception cref="ArgumentException">Thrown when color of the shape is an empty string after trimming whitespace.</exception>
        public GeometricShape(string color, bool isFilled)
        {
            color = color.Trim();
            if(string.IsNullOrEmpty(color))
            {
                throw new ArgumentException("Color cannot be 0 characters", "color");
            }
            else
            {
                this.color = color;
                this.isFilled = isFilled;
            }
        }

        /// <summary>
        /// Initializes an instance of a geometric shape with a white color and a state of not filled.
        /// </summary>
        public GeometricShape() : this("White", false)
        {

        }

        /// <summary>
        /// Gets and sets the color of the geometric shape.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when color is set to an empty string even after removing whitespace.
        /// </exception>
        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                if(string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException("Color value cannot be 0 characters");
                }
                else
                {
                    this.color = value;
                }
            }
        }

        /// <summary>
        /// Gets and sets if the shape is filled or not.
        /// </summary>
        /// <remarks>This is a boolean value.</remarks>
        public bool IsFilled
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the area of the shape.
        /// </summary>
        public abstract decimal Area
        {
            get;
        }

        /// <summary>
        /// Gets the Perimeter of the shape.
        /// </summary>
        public abstract decimal Perimeter
        {
            get;
        }

        /// <summary>
        /// Returns the string representation of the shape.
        /// </summary>
        /// <returns>String representation of the shape.</returns>
        public override string ToString()
        {
            return $"Color: {this.Color}    IsFilled: {this.IsFilled}";
        }
    }
}