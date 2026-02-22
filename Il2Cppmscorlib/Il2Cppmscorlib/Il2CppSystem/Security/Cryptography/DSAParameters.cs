using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E3 RID: 739
	[Serializable]
	public sealed class DSAParameters : ValueType
	{
		// Token: 0x060030B6 RID: 12470 RVA: 0x000F30F4 File Offset: 0x000F12F4
		// Note: this type is marked as 'beforefieldinit'.
		static DSAParameters()
		{
			Il2CppClassPointerStore<DSAParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSAParameters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr);
			DSAParameters.NativeFieldInfoPtr_P = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "P");
			DSAParameters.NativeFieldInfoPtr_Q = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "Q");
			DSAParameters.NativeFieldInfoPtr_G = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "G");
			DSAParameters.NativeFieldInfoPtr_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "Y");
			DSAParameters.NativeFieldInfoPtr_J = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "J");
			DSAParameters.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "X");
			DSAParameters.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "Seed");
			DSAParameters.NativeFieldInfoPtr_Counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr, "Counter");
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x00011386 File Offset: 0x0000F586
		public DSAParameters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060030B8 RID: 12472 RVA: 0x0001138F File Offset: 0x0000F58F
		public DSAParameters()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSAParameters>.NativeClassPtr))
		{
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x060030B9 RID: 12473 RVA: 0x000F31C4 File Offset: 0x000F13C4
		// (set) Token: 0x060030BA RID: 12474 RVA: 0x000113A1 File Offset: 0x0000F5A1
		public unsafe Il2CppStructArray<byte> P
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_P);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_P), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x060030BB RID: 12475 RVA: 0x000F31F4 File Offset: 0x000F13F4
		// (set) Token: 0x060030BC RID: 12476 RVA: 0x000113C0 File Offset: 0x0000F5C0
		public unsafe Il2CppStructArray<byte> Q
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Q);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Q), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x060030BD RID: 12477 RVA: 0x000F3224 File Offset: 0x000F1424
		// (set) Token: 0x060030BE RID: 12478 RVA: 0x000113DF File Offset: 0x0000F5DF
		public unsafe Il2CppStructArray<byte> G
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_G);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_G), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x060030BF RID: 12479 RVA: 0x000F3254 File Offset: 0x000F1454
		// (set) Token: 0x060030C0 RID: 12480 RVA: 0x000113FE File Offset: 0x0000F5FE
		public unsafe Il2CppStructArray<byte> Y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Y);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Y), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x060030C1 RID: 12481 RVA: 0x000F3284 File Offset: 0x000F1484
		// (set) Token: 0x060030C2 RID: 12482 RVA: 0x0001141D File Offset: 0x0000F61D
		public unsafe Il2CppStructArray<byte> J
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_J);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_J), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x060030C3 RID: 12483 RVA: 0x000F32B4 File Offset: 0x000F14B4
		// (set) Token: 0x060030C4 RID: 12484 RVA: 0x0001143C File Offset: 0x0000F63C
		public unsafe Il2CppStructArray<byte> X
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_X);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_X), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x060030C5 RID: 12485 RVA: 0x000F32E4 File Offset: 0x000F14E4
		// (set) Token: 0x060030C6 RID: 12486 RVA: 0x0001145B File Offset: 0x0000F65B
		public unsafe Il2CppStructArray<byte> Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x060030C7 RID: 12487 RVA: 0x000F3314 File Offset: 0x000F1514
		// (set) Token: 0x060030C8 RID: 12488 RVA: 0x0001147A File Offset: 0x0000F67A
		public unsafe int Counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DSAParameters.NativeFieldInfoPtr_Counter)) = value;
			}
		}

		// Token: 0x040029F3 RID: 10739
		private static readonly IntPtr NativeFieldInfoPtr_P;

		// Token: 0x040029F4 RID: 10740
		private static readonly IntPtr NativeFieldInfoPtr_Q;

		// Token: 0x040029F5 RID: 10741
		private static readonly IntPtr NativeFieldInfoPtr_G;

		// Token: 0x040029F6 RID: 10742
		private static readonly IntPtr NativeFieldInfoPtr_Y;

		// Token: 0x040029F7 RID: 10743
		private static readonly IntPtr NativeFieldInfoPtr_J;

		// Token: 0x040029F8 RID: 10744
		private static readonly IntPtr NativeFieldInfoPtr_X;

		// Token: 0x040029F9 RID: 10745
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x040029FA RID: 10746
		private static readonly IntPtr NativeFieldInfoPtr_Counter;
	}
}
