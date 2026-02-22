using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000147 RID: 327
	[StructLayout(2)]
	public struct Variant
	{
		// Token: 0x060016F7 RID: 5879 RVA: 0x00089254 File Offset: 0x00087454
		// Note: this type is marked as 'beforefieldinit'.
		static Variant()
		{
			Il2CppClassPointerStore<Variant>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Variant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Variant>.NativeClassPtr);
			Variant.NativeFieldInfoPtr_vt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "vt");
			Variant.NativeFieldInfoPtr_wReserved1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "wReserved1");
			Variant.NativeFieldInfoPtr_wReserved2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "wReserved2");
			Variant.NativeFieldInfoPtr_wReserved3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "wReserved3");
			Variant.NativeFieldInfoPtr_llVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "llVal");
			Variant.NativeFieldInfoPtr_lVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "lVal");
			Variant.NativeFieldInfoPtr_bVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "bVal");
			Variant.NativeFieldInfoPtr_iVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "iVal");
			Variant.NativeFieldInfoPtr_fltVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "fltVal");
			Variant.NativeFieldInfoPtr_dblVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "dblVal");
			Variant.NativeFieldInfoPtr_boolVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "boolVal");
			Variant.NativeFieldInfoPtr_bstrVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "bstrVal");
			Variant.NativeFieldInfoPtr_cVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "cVal");
			Variant.NativeFieldInfoPtr_uiVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "uiVal");
			Variant.NativeFieldInfoPtr_ulVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "ulVal");
			Variant.NativeFieldInfoPtr_ullVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "ullVal");
			Variant.NativeFieldInfoPtr_intVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "intVal");
			Variant.NativeFieldInfoPtr_uintVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "uintVal");
			Variant.NativeFieldInfoPtr_pdispVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "pdispVal");
			Variant.NativeFieldInfoPtr_bRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Variant>.NativeClassPtr, "bRecord");
			Variant.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Variant>.NativeClassPtr, 100667148);
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00089428 File Offset: 0x00087628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309417, XrefRangeEnd = 309426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Variant.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x0000818E File Offset: 0x0000638E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Variant>.NativeClassPtr, ref this));
		}

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeFieldInfoPtr_vt;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeFieldInfoPtr_wReserved1;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeFieldInfoPtr_wReserved2;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeFieldInfoPtr_wReserved3;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeFieldInfoPtr_llVal;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeFieldInfoPtr_lVal;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeFieldInfoPtr_bVal;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeFieldInfoPtr_iVal;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeFieldInfoPtr_fltVal;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeFieldInfoPtr_dblVal;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeFieldInfoPtr_boolVal;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeFieldInfoPtr_bstrVal;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeFieldInfoPtr_cVal;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeFieldInfoPtr_uiVal;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeFieldInfoPtr_ulVal;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeFieldInfoPtr_ullVal;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeFieldInfoPtr_intVal;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeFieldInfoPtr_uintVal;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeFieldInfoPtr_pdispVal;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeFieldInfoPtr_bRecord;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400151E RID: 5406
		[FieldOffset(0)]
		public short vt;

		// Token: 0x0400151F RID: 5407
		[FieldOffset(2)]
		public ushort wReserved1;

		// Token: 0x04001520 RID: 5408
		[FieldOffset(4)]
		public ushort wReserved2;

		// Token: 0x04001521 RID: 5409
		[FieldOffset(6)]
		public ushort wReserved3;

		// Token: 0x04001522 RID: 5410
		[FieldOffset(8)]
		public long llVal;

		// Token: 0x04001523 RID: 5411
		[FieldOffset(8)]
		public int lVal;

		// Token: 0x04001524 RID: 5412
		[FieldOffset(8)]
		public byte bVal;

		// Token: 0x04001525 RID: 5413
		[FieldOffset(8)]
		public short iVal;

		// Token: 0x04001526 RID: 5414
		[FieldOffset(8)]
		public float fltVal;

		// Token: 0x04001527 RID: 5415
		[FieldOffset(8)]
		public double dblVal;

		// Token: 0x04001528 RID: 5416
		[FieldOffset(8)]
		public short boolVal;

		// Token: 0x04001529 RID: 5417
		[FieldOffset(8)]
		public IntPtr bstrVal;

		// Token: 0x0400152A RID: 5418
		[FieldOffset(8)]
		public sbyte cVal;

		// Token: 0x0400152B RID: 5419
		[FieldOffset(8)]
		public ushort uiVal;

		// Token: 0x0400152C RID: 5420
		[FieldOffset(8)]
		public uint ulVal;

		// Token: 0x0400152D RID: 5421
		[FieldOffset(8)]
		public ulong ullVal;

		// Token: 0x0400152E RID: 5422
		[FieldOffset(8)]
		public int intVal;

		// Token: 0x0400152F RID: 5423
		[FieldOffset(8)]
		public uint uintVal;

		// Token: 0x04001530 RID: 5424
		[FieldOffset(8)]
		public IntPtr pdispVal;

		// Token: 0x04001531 RID: 5425
		[FieldOffset(8)]
		public BRECORD bRecord;
	}
}
