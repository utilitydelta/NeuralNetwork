﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork
{
    public class DigitImage
    {
        public byte[,] pixels;
        public byte label;

        public DigitImage(byte[,] pixels,
          byte label)
        {
            this.pixels = new byte[28,28];

            for (int i = 0; i < 28; ++i)
                for (int j = 0; j < 28; ++j)
                    this.pixels[i,j] = pixels[i,j];

            this.label = label;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < 28; ++i)
            {
                for (int j = 0; j < 28; ++j)
                {
                    if (this.pixels[i,j] == 0)
                        s += " "; // white
                    else if (this.pixels[i,j] == 255)
                        s += "O"; // black
                    else
                        s += "."; // gray
                }
                s += "\n";
            }
            s += this.label.ToString();
            return s;
        } // ToString

    }
}
