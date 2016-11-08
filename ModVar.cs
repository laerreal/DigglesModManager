﻿namespace DigglesModManager
{
    public abstract class ModVar
    {
        public string VarName;
        public string Type;
        public string Description;

        public abstract string GetValueAsString();
    }

    public class ModVar<T> : ModVar
    {
        public T GameValue;
        public T StdValue;
        public T MinValue;
        public T MaxValue;

        public T Value;

        public ModVar(string varName, string type, string description, T gameValue, T stdValue, T value)
        {
            VarName = varName;
            Type = type;
            Description = description;
            GameValue = gameValue;
            StdValue = stdValue;
            Value = value;
        }

        public ModVar(string varName, string type, string description, T gameValue, T stdValue, T value, T minValue, T maxValue)
            : this(varName, type, description, gameValue, stdValue, value)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public override string GetValueAsString()
        {
            return Value.ToString();
        }
    }
}
