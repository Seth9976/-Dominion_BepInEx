using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002FD RID: 765
	[Serializable]
	public sealed class RSAParameters : ValueType
	{
		// Token: 0x060031FB RID: 12795 RVA: 0x000F7A60 File Offset: 0x000F5C60
		// Note: this type is marked as 'beforefieldinit'.
		static RSAParameters()
		{
			Il2CppClassPointerStore<RSAParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RSAParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr);
			RSAParameters.NativeFieldInfoPtr_Exponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "Exponent");
			RSAParameters.NativeFieldInfoPtr_Modulus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "Modulus");
			RSAParameters.NativeFieldInfoPtr_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "P");
			RSAParameters.NativeFieldInfoPtr_Q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "Q");
			RSAParameters.NativeFieldInfoPtr_DP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "DP");
			RSAParameters.NativeFieldInfoPtr_DQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "DQ");
			RSAParameters.NativeFieldInfoPtr_InverseQ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "InverseQ");
			RSAParameters.NativeFieldInfoPtr_D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr, "D");
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x00011BC2 File Offset: 0x0000FDC2
		public RSAParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x00011BCB File Offset: 0x0000FDCB
		public RSAParameters()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RSAParameters>.NativeClassPtr))
		{
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x060031FE RID: 12798 RVA: 0x000F7B30 File Offset: 0x000F5D30
		// (set) Token: 0x060031FF RID: 12799 RVA: 0x00011BDD File Offset: 0x0000FDDD
		public unsafe Il2CppStructArray<byte> Exponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Exponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Exponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06003200 RID: 12800 RVA: 0x000F7B60 File Offset: 0x000F5D60
		// (set) Token: 0x06003201 RID: 12801 RVA: 0x00011BFC File Offset: 0x0000FDFC
		public unsafe Il2CppStructArray<byte> Modulus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Modulus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Modulus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06003202 RID: 12802 RVA: 0x000F7B90 File Offset: 0x000F5D90
		// (set) Token: 0x06003203 RID: 12803 RVA: 0x00011C1B File Offset: 0x0000FE1B
		public unsafe Il2CppStructArray<byte> P
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_P);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_P), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06003204 RID: 12804 RVA: 0x000F7BC0 File Offset: 0x000F5DC0
		// (set) Token: 0x06003205 RID: 12805 RVA: 0x00011C3A File Offset: 0x0000FE3A
		public unsafe Il2CppStructArray<byte> Q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Q);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_Q), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06003206 RID: 12806 RVA: 0x000F7BF0 File Offset: 0x000F5DF0
		// (set) Token: 0x06003207 RID: 12807 RVA: 0x00011C59 File Offset: 0x0000FE59
		public unsafe Il2CppStructArray<byte> DP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_DP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_DP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06003208 RID: 12808 RVA: 0x000F7C20 File Offset: 0x000F5E20
		// (set) Token: 0x06003209 RID: 12809 RVA: 0x00011C78 File Offset: 0x0000FE78
		public unsafe Il2CppStructArray<byte> DQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_DQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_DQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x0600320A RID: 12810 RVA: 0x000F7C50 File Offset: 0x000F5E50
		// (set) Token: 0x0600320B RID: 12811 RVA: 0x00011C97 File Offset: 0x0000FE97
		public unsafe Il2CppStructArray<byte> InverseQ
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_InverseQ);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_InverseQ), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600320C RID: 12812 RVA: 0x000F7C80 File Offset: 0x000F5E80
		// (set) Token: 0x0600320D RID: 12813 RVA: 0x00011CB6 File Offset: 0x0000FEB6
		public unsafe Il2CppStructArray<byte> D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RSAParameters.NativeFieldInfoPtr_D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002AC4 RID: 10948
		private static readonly IntPtr NativeFieldInfoPtr_Exponent;

		// Token: 0x04002AC5 RID: 10949
		private static readonly IntPtr NativeFieldInfoPtr_Modulus;

		// Token: 0x04002AC6 RID: 10950
		private static readonly IntPtr NativeFieldInfoPtr_P;

		// Token: 0x04002AC7 RID: 10951
		private static readonly IntPtr NativeFieldInfoPtr_Q;

		// Token: 0x04002AC8 RID: 10952
		private static readonly IntPtr NativeFieldInfoPtr_DP;

		// Token: 0x04002AC9 RID: 10953
		private static readonly IntPtr NativeFieldInfoPtr_DQ;

		// Token: 0x04002ACA RID: 10954
		private static readonly IntPtr NativeFieldInfoPtr_InverseQ;

		// Token: 0x04002ACB RID: 10955
		private static readonly IntPtr NativeFieldInfoPtr_D;
	}
}
