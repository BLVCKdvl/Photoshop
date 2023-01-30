﻿using System;

namespace MyPhotoshop
{
    public abstract class ParametrizedFilter : IFilter
    {
        public IParameters parameters;

        public ParametrizedFilter(IParameters parameters) 
        {
            this.parameters = parameters;
        }
        public ParameterInfo[] GetParameters()
        {
            return parameters.GetDescription();
        }

        public Photo Process(Photo original, double[] values)
        {
            this.parameters.SetValues(values);
            return Process(original, parameters);
        }
        public abstract Photo Process(Photo photo, IParameters parameters);
    }
}
