using System;

namespace General.Shapes
{
    /// <summary>
    /// Represents a triangle.
    /// </summary>
    public class Triangle : GeometricShape
    {
        private decimal side1;
        private decimal side2;
        private decimal side3;

        /// <summary>
        /// Initializes an instance of a triangle shape with a given Side 1, Side 2 and Side 3.
        /// </summary>
        /// <param name="side1">Side 1 of the triangle.</param>
        /// <param name="side2">Side 2 of the triangle.</param>
        /// <param name="side3">Side 3 of the triangle.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when Side 1, Side 2 or Side 3 is passed as a value lesser than or equal to 0.
        /// </exception>
        public Triangle(decimal side1, decimal side2, decimal side3)
        {
            if(side1 <= 0)
            {
                throw new ArgumentOutOfRangeException("Side 1 cannot be lesser than 0", "side1");
            }
            else if(side2 <= 0)
            {
                throw new ArgumentOutOfRangeException("Side 1 cannot be lesser than 0", "side1");
            }
            else if(side3 <= 0)
            {
                throw new ArgumentOutOfRangeException("Side 1 cannot be lesser than 0", "side1");
            }
            else
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
        }

        /// <summary>
        /// Initializes an instance of a triangle shape with a given Side 1, Side 2, Side 3, color and whether its filled or not. 
        /// </summary>
        /// <param name="side1">Side 1 of the triangle</param>
        /// <param name="side2">Side 2 of the triangle.</param>
        /// <param name="side3">Side 3 of the triangle.</param>
        /// <param name="color">Color of the traingle.</param>
        /// <param name="isFilled">The filled state of the triangle - Filled or not.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when Side 1, Side 2 or Side 3 is passed as a value lesser than or equal to 0.
        /// </exception>
        public Triangle(decimal side1, decimal side2, decimal side3, string color, bool isFilled) : base(color, isFilled)
        {
            if (side1 <= 0)
            {
                throw new ArgumentOutOfRangeException("Side 1 cannot be lesser than 0", "side1");
            }
            else if (side2 <= 0)
            {
                throw new ArgumentOutOfRangeException("Side 1 cannot be lesser than 0", "side1");
            }
            else if (side3 <= 0)
            {
                throw new ArgumentOutOfRangeException("Side 1 cannot be lesser than 0", "side1");
            }
            else
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
        }

        /// <summary>
        /// Gets and sets side 1 of the triangle.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when side 1 is passed as a value lesser than or equal to 0.
        /// </exception>
        public decimal Side1
        {
            get
            {
                return this.side1;
            }

            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Side 1 cannot be lesser than 0", "side1");
                }
                else
                {
                    this.side1 = value;
                }
            }
        }

        /// <summary>
        /// Gets and sets side 2 of the triangle.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when side 2 is passed as a value lesser than or equal to 0.
        /// </exception>
        public decimal Side2
        {
            get
            {
                return this.side2;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Side 2 cannot be lesser than 0", "side2");
                }
                else
                {
                    this.side2 = value;
                }
            }
        }

        /// <summary>
        /// Gets and sets side 3 of the triangle.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when side 3 is passed as a value lesser than or equal to 0.
        /// </exception>
        public decimal Side3
        {
            get
            {
                return this.side3;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Side 3 cannot be lesser than 0", "side3");
                }
                else
                {
                    this.side3 = value;
                }
            }
        }

        /// <summary>
        /// Gets the area of the triangle.
        /// </summary>
        public override decimal Area
        {
            get
            {
                decimal s = (this.Side1 + this.Side2 + this.Side3) / 2.0m;
                decimal area = (decimal)Math.Sqrt((double)(s * (s - this.Side1) * (s - this.Side2) * (s - this.Side3)));
                return area;
            }
        }

        /// <summary>
        /// Gets the perimeter of the triangle.
        /// </summary>
        public override decimal Perimeter
        {
            get
            {
                return (this.Side1 + this.Side2 + this.Side3);
            }
        }

        /// <summary>
        /// Returns a string representation of the triangle.
        /// </summary>
        /// <returns>String representation of the triangle.</returns>
        public override string ToString()
        {
            return base.ToString() + $"\nSide 1: {this.Side1}      Side 2: {this.Side2}     Side 3: {this.Side3}       " +
            $"Area: {this.Area}     Perimeter: { this.Perimeter}";
        }
    }
}