using System;

namespace UnityEngine
{
	// Token: 0x0200021F RID: 543
	public static class SpookyHash
	{
		// Token: 0x06001ED7 RID: 7895 RVA: 0x00064DC0 File Offset: 0x00062FC0
		public static bool AttemptDetectAllowUnalignedRead()
		{
			string processorType = SystemInfo.processorType;
			string text = processorType;
			if (text != null)
			{
				if (text == "x86" || text == "AMD64")
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00011AF2 File Offset: 0x0000FCF2
		public unsafe static void Hash(void* message, ulong length, ulong* hash1, ulong* hash2)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00064E00 File Offset: 0x00063000
		public unsafe static void End(ulong* data, ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11)
		{
			h0 += *data;
			h1 += data[1];
			h2 += data[2];
			h3 += data[3];
			h4 += data[4];
			h5 += data[5];
			h6 += data[6];
			h7 += data[7];
			h8 += data[8];
			h9 += data[9];
			h10 += data[10];
			h11 += data[11];
			SpookyHash.EndPartial(ref h0, ref h1, ref h2, ref h3, ref h4, ref h5, ref h6, ref h7, ref h8, ref h9, ref h10, ref h11);
			SpookyHash.EndPartial(ref h0, ref h1, ref h2, ref h3, ref h4, ref h5, ref h6, ref h7, ref h8, ref h9, ref h10, ref h11);
			SpookyHash.EndPartial(ref h0, ref h1, ref h2, ref h3, ref h4, ref h5, ref h6, ref h7, ref h8, ref h9, ref h10, ref h11);
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x00064EFC File Offset: 0x000630FC
		public static void EndPartial(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3, ref ulong h4, ref ulong h5, ref ulong h6, ref ulong h7, ref ulong h8, ref ulong h9, ref ulong h10, ref ulong h11)
		{
			h11 += h1;
			h2 ^= h11;
			SpookyHash.Rot64(ref h1, 44);
			h0 += h2;
			h3 ^= h0;
			SpookyHash.Rot64(ref h2, 15);
			h1 += h3;
			h4 ^= h1;
			SpookyHash.Rot64(ref h3, 34);
			h2 += h4;
			h5 ^= h2;
			SpookyHash.Rot64(ref h4, 21);
			h3 += h5;
			h6 ^= h3;
			SpookyHash.Rot64(ref h5, 38);
			h4 += h6;
			h7 ^= h4;
			SpookyHash.Rot64(ref h6, 33);
			h5 += h7;
			h8 ^= h5;
			SpookyHash.Rot64(ref h7, 10);
			h6 += h8;
			h9 ^= h6;
			SpookyHash.Rot64(ref h8, 13);
			h7 += h9;
			h10 ^= h7;
			SpookyHash.Rot64(ref h9, 38);
			h8 += h10;
			h11 ^= h8;
			SpookyHash.Rot64(ref h10, 53);
			h9 += h11;
			h0 ^= h9;
			SpookyHash.Rot64(ref h11, 42);
			h10 += h0;
			h1 ^= h10;
			SpookyHash.Rot64(ref h0, 54);
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x00011AFF File Offset: 0x0000FCFF
		public static void Rot64(ref ulong x, int k)
		{
			x = (x << k) | (x >> 64 - k);
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x00011B16 File Offset: 0x0000FD16
		public unsafe static void Short(void* message, ulong length, ulong* hash1, ulong* hash2)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00065058 File Offset: 0x00063258
		public static void ShortMix(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
		{
			SpookyHash.Rot64(ref h2, 50);
			h2 += h3;
			h0 ^= h2;
			SpookyHash.Rot64(ref h3, 52);
			h3 += h0;
			h1 ^= h3;
			SpookyHash.Rot64(ref h0, 30);
			h0 += h1;
			h2 ^= h0;
			SpookyHash.Rot64(ref h1, 41);
			h1 += h2;
			h3 ^= h1;
			SpookyHash.Rot64(ref h2, 54);
			h2 += h3;
			h0 ^= h2;
			SpookyHash.Rot64(ref h3, 48);
			h3 += h0;
			h1 ^= h3;
			SpookyHash.Rot64(ref h0, 38);
			h0 += h1;
			h2 ^= h0;
			SpookyHash.Rot64(ref h1, 37);
			h1 += h2;
			h3 ^= h1;
			SpookyHash.Rot64(ref h2, 62);
			h2 += h3;
			h0 ^= h2;
			SpookyHash.Rot64(ref h3, 34);
			h3 += h0;
			h1 ^= h3;
			SpookyHash.Rot64(ref h0, 5);
			h0 += h1;
			h2 ^= h0;
			SpookyHash.Rot64(ref h1, 36);
			h1 += h2;
			h3 ^= h1;
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x0006517C File Offset: 0x0006337C
		public static void ShortEnd(ref ulong h0, ref ulong h1, ref ulong h2, ref ulong h3)
		{
			h3 ^= h2;
			SpookyHash.Rot64(ref h2, 15);
			h3 += h2;
			h0 ^= h3;
			SpookyHash.Rot64(ref h3, 52);
			h0 += h3;
			h1 ^= h0;
			SpookyHash.Rot64(ref h0, 26);
			h1 += h0;
			h2 ^= h1;
			SpookyHash.Rot64(ref h1, 51);
			h2 += h1;
			h3 ^= h2;
			SpookyHash.Rot64(ref h2, 28);
			h3 += h2;
			h0 ^= h3;
			SpookyHash.Rot64(ref h3, 9);
			h0 += h3;
			h1 ^= h0;
			SpookyHash.Rot64(ref h0, 47);
			h1 += h0;
			h2 ^= h1;
			SpookyHash.Rot64(ref h1, 54);
			h2 += h1;
			h3 ^= h2;
			SpookyHash.Rot64(ref h2, 32);
			h3 += h2;
			h0 ^= h3;
			SpookyHash.Rot64(ref h3, 25);
			h0 += h3;
			h1 ^= h0;
			SpookyHash.Rot64(ref h0, 63);
			h1 += h0;
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x00065288 File Offset: 0x00063488
		public unsafe static void Mix(ulong* data, ref ulong s0, ref ulong s1, ref ulong s2, ref ulong s3, ref ulong s4, ref ulong s5, ref ulong s6, ref ulong s7, ref ulong s8, ref ulong s9, ref ulong s10, ref ulong s11)
		{
			s0 += *data;
			s2 ^= s10;
			s11 ^= s0;
			SpookyHash.Rot64(ref s0, 11);
			s11 += s1;
			s1 += data[1];
			s3 ^= s11;
			s0 ^= s1;
			SpookyHash.Rot64(ref s1, 32);
			s0 += s2;
			s2 += data[2];
			s4 ^= s0;
			s1 ^= s2;
			SpookyHash.Rot64(ref s2, 43);
			s1 += s3;
			s3 += data[3];
			s5 ^= s1;
			s2 ^= s3;
			SpookyHash.Rot64(ref s3, 31);
			s2 += s4;
			s4 += data[4];
			s6 ^= s2;
			s3 ^= s4;
			SpookyHash.Rot64(ref s4, 17);
			s3 += s5;
			s5 += data[5];
			s7 ^= s3;
			s4 ^= s5;
			SpookyHash.Rot64(ref s5, 28);
			s4 += s6;
			s6 += data[6];
			s8 ^= s4;
			s5 ^= s6;
			SpookyHash.Rot64(ref s6, 39);
			s5 += s7;
			s7 += data[7];
			s9 ^= s5;
			s6 ^= s7;
			SpookyHash.Rot64(ref s7, 57);
			s6 += s8;
			s8 += data[8];
			s10 ^= s6;
			s7 ^= s8;
			SpookyHash.Rot64(ref s8, 55);
			s7 += s9;
			s9 += data[9];
			s11 ^= s7;
			s8 ^= s9;
			SpookyHash.Rot64(ref s9, 54);
			s8 += s10;
			s10 += data[10];
			s0 ^= s8;
			s9 ^= s10;
			SpookyHash.Rot64(ref s10, 22);
			s9 += s11;
			s11 += data[11];
			s1 ^= s9;
			s10 ^= s11;
			SpookyHash.Rot64(ref s11, 46);
			s10 += s0;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x000654F8 File Offset: 0x000636F8
		public unsafe static void memset(void* dst, int value, ulong numberOfBytes)
		{
			ulong num = (ulong)(value | value);
			ulong* ptr = (ulong*)dst;
			ulong num2 = numberOfBytes >> 3;
			for (ulong num3 = 0UL; num3 < num2; num3 += 1UL)
			{
				ptr[num3 * 8UL / 8UL] = num;
			}
			dst = (void*)ptr;
			numberOfBytes -= num2;
			byte* ptr2 = stackalloc byte[(UIntPtr)4];
			*ptr2 = (byte)(value & 15);
			ptr2[1] = (byte)(((uint)value >> 4) & 15U);
			ptr2[2] = (byte)(((uint)value >> 8) & 15U);
			ptr2[3] = (byte)(((uint)value >> 12) & 15U);
			byte* ptr3 = (byte*)dst;
			ulong num4 = numberOfBytes;
			for (ulong num5 = 0UL; num5 < num4; num5 += 1UL)
			{
				ptr3[num5] = ptr2[num5 % 4UL];
			}
		}

		// Token: 0x04001875 RID: 6261
		public const int k_NumVars = 12;

		// Token: 0x04001876 RID: 6262
		public const int k_BlockSize = 96;

		// Token: 0x04001877 RID: 6263
		public const int k_BufferSize = 192;

		// Token: 0x04001878 RID: 6264
		public const ulong k_DeadBeefConst = 16045690984833335023UL;
	}
}
