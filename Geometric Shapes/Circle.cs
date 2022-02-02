using System;
using System.Drawing;

namespace General.Shapes
{
    /// <summary>
    /// Represents a circle.
    /// </summary>
    public class Circle : GeometricShape
    {
        private decimal radius;

        /// <summary>
        /// Initializes an instance of a circle shape with a radius of 1 that is filled white in color.
        /// </summary>
        public Circle() : this(1)
        {
        }

        /// <summary>
        /// Initializes an instance of a circle shape with a given radius that is filled white in color.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when specifying a radius less than or equal to 0.</exception>
        public Circle(decimal radius) : this(radius, Color.White, true)
        {
        }

        /// <summary>
        /// Initializes an instance of a circle shape with a given radius, color and if the circle is filled or not.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <param name="color">The color of the circle.</param>
        /// <param name="isFilled">The filled state of the circle - Filled or not.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when specifying a radius less than or equal to 0.</exception>
        /// <exception cref="ArgumentException">Thrown when color of the shape is specified as null.</exception>
        public Circle(decimal radius, Color color, bool isFilled) : base(color, isFilled)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("radius", "The Circle's radius cannot be set to less than or equal to 0.");
            }
            
            this.radius = radius;
        }

        /// <summary>
        /// Gets and sets the radius of the circle.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when radius is set to a value lesser than or equal to 0.
        /// </exception>
        public decimal Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The Circle's Radius cannot be set to less than or equal to 0.");
                }
                
                this.radius = value;
            }
        }

        /// <summary>
        /// Gets the area of the circle.
        /// </summary>
        public override decimal Area
        {
            get
            {
                return (decimal)Math.PI * (this.Radius * this.Radius);
            }
        }

        /// <summary>
        /// Gets the perimeter of the circle.
        /// </summary>
        public override decimal Perimeter
        {
            get
            {
                return 2.0M * (decimal)Math.PI * this.Radius;
            }
        }

        /// <summary>
        /// Gets the diameter of the circle.
        /// </summary>
        public decimal Diameter
        {
            get
            {
                return 2.0M * this.Radius;
            }
        }

        /// <summary>
        /// Returns a string representation of the circle.
        /// </summary>
        /// <returns>String representation of the circle.</returns>
        public override string ToString()
        {
            return base.ToString() + $"\nRadius: {this.Radius}      Area: {this.Area}     Perimeter: {this.Perimeter}       " +
            $"Diameter: {this.Diameter}";
        }

    }
}
