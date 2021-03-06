﻿using System;
using Randomizer.Interfaces.ReferenceTypes;

// ReSharper disable once CheckNamespace
namespace Randomizer
{
    public class RandomAlphanumericCharGenerator : RandomGeneratorBase, IRandomCharacter
    {
        public RandomAlphanumericCharGenerator()
        {
            
        }
        public RandomAlphanumericCharGenerator(int seed)
            :base(seed)
        {
        }

        public char GenerateValue()
        {
            int indexofCharacter = randomizer.Next(0, Consts.AlphanumericCharacters.Length - 1);
            return Consts.AlphanumericCharArray[indexofCharacter];
        }

        public char GenerateValue(char min, char max)
        {
            if (IsConditionToReachLimit())
            {
                return max;
            }

            int firstIndex = Consts.AlphanumericCharacters.IndexOf(min);
            int lastIndex = Consts.AlphanumericCharacters.IndexOf(max);

            if (firstIndex >= lastIndex)
            {
                throw new ArgumentException(Consts.MinMaxValueExceptionMsg);
            }

            int randomIndex = randomizer.Next(firstIndex, lastIndex);
            return Consts.AlphanumericCharArray[randomIndex];
        }
    }
}
