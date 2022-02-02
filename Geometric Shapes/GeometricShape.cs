using System;
using System.Drawing;

namespace General.Shapes
{
    /// <summary>
    /// Represents a generalized geometric shape.
    /// </summary>
    public abstract class GeometricShape
    {
        private Color color;
        private bool isFilled;

        /// <summary>
        /// Initializes an instance of a geometric shape with a given color and whether if its filled or not.
        /// </summary>
        /// <param name="color">The color of the shape.</param>
        /// <param name="isFilled">If the shape is filled or not.</param>
        /// <exception cref="ArgumentException">Thrown when color of the shape is specified as null.</exception>
        public GeometricShape(Color color, bool isFilled)
        {
            if(color == null)
            {
                throw new ArgumentException("Color cannot be null.", "color");
            }
            
            this.Color = color;
            this.isFilled = isFilled;
        }

        /// <summary>
        /// Initializes an instance of a geometric shape with a white color and a state of not filled.
        /// </summary>
        public GeometricShape() : this(Color.White, false)
        {

        }

        /// <summary>
        /// Gets and sets the color of the geometric shape.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when color of the shape is set as null.
        /// </exception>
        public Color Color
        {
            get
            {
                return this.color;
            }

            set
            {
                if(value == null)
                {
                    throw new ArgumentException("Color value cannot be null.");
                }
                this.color = value;
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
        /// Gets the perimeter of the shape.
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
