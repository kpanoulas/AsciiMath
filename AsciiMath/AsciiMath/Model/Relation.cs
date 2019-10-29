using System;
using System.Collections.Generic;
using System.Text;

namespace AsciiMath.Builders
{
    public enum Relation
    {
        Equality,
        NonEquality,
        LessThan,
        GreaterThan,
        LessThanOrEqual,
        GreaterThanOrEqual,
        In,
        NotIn,
        Subset,
        Superset,
        SubsetOrEqual,
        SupersetOrEqual,
        Equilalence,
        Approximation,
    }
}
