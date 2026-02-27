using System.Text;
using UnityEngine;

namespace UsefulUtilities
{
    /// <summary>
    /// Each bit represents a different flag stored in a uint, for a total of 32 flags (32 bit).
    /// </summary>
    public struct BitFlags
    {
        public uint flags;

        public BitFlags(uint flags)
        {
            this.flags = flags;
        }

        public BitFlags(params uint[] flags)
        {
            this.flags = 0;

            if (flags.Length > 32)
            {
                Debug.LogError($"Error: Max flags length is 32. Flags Length: {flags.Length}");
                return;
            }

            for (int i = 0; i < flags.Length; i++)
            {
                SetBitFlag((int)flags[i], true);
            }
        }

        public BitFlags(params int[] flags)
        {
            this.flags = 0;

            if (flags.Length > 32)
            {
                Debug.LogError($"Error: Max flags length is 32. Flags Length: {flags.Length}");
                return;
            }

            for (int i = 0; i < flags.Length; i++)
            {
                SetBitFlag(flags[i], true);
            }
        }

        public BitFlags(params bool[] flags)
        {
            this.flags = 0;

            if (flags.Length > 32)
            {
                Debug.LogError($"Error: Max flags length is 32. Flags Length: {flags.Length}");
                return;
            }

            for (int i = 0; i < flags.Length; i++)
            {
                SetBitFlag(i, flags[i]);
            }
        }

        public void SetBitFlag(int index, bool value)
        {
            if (index < 0 || index > 31)
            {
                Debug.LogError($"Error: Index is out of range (0-31). Index: {index}");
                return;
            }

            flags &= ~(1u << index);
            if (value)
            {
                flags |= 1u << index;
            }
        }

        public bool GetBitFlag(int index)
        {
            return (flags & (1u << index)) != 0;
        }

        /// <summary>
        /// Returns the all the flags represented in binary (0 or 1)
        /// </summary>
        /// <returns>A string containing all flags</returns>
        public override string ToString()
        {
            StringBuilder binaryString = new StringBuilder();
            for (int i = 0; i < 32; i++)
            {
                bool flag = GetBitFlag(i);
                binaryString.Append((flag ? "1" : "0") + ", ");
            }
            binaryString.Remove(binaryString.Length - 2, 2);
            return binaryString.ToString();
        }
    }
}