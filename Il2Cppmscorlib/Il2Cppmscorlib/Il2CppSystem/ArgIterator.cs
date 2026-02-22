using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200010B RID: 267
	[StructLayout(2)]
	public struct ArgIterator
	{
		// Token: 0x060013D8 RID: 5080 RVA: 0x0007D228 File Offset: 0x0007B428
		// Note: this type is marked as 'beforefieldinit'.
		static ArgIterator()
		{
			Il2CppClassPointerStore<ArgIterator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArgIterator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr);
			ArgIterator.NativeFieldInfoPtr_sig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "sig");
			ArgIterator.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "args");
			ArgIterator.NativeFieldInfoPtr_next_arg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "next_arg");
			ArgIterator.NativeFieldInfoPtr_num_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, "num_args");
			ArgIterator.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, 100666703);
			ArgIterator.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, 100666704);
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0007D2D0 File Offset: 0x0007B4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304566, XrefRangeEnd = 304573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgIterator.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0007D314 File Offset: 0x0007B514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgIterator.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x00006EFC File Offset: 0x000050FC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArgIterator>.NativeClassPtr, ref this));
		}

		// Token: 0x04001101 RID: 4353
		private static readonly IntPtr NativeFieldInfoPtr_sig;

		// Token: 0x04001102 RID: 4354
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x04001103 RID: 4355
		private static readonly IntPtr NativeFieldInfoPtr_next_arg;

		// Token: 0x04001104 RID: 4356
		private static readonly IntPtr NativeFieldInfoPtr_num_args;

		// Token: 0x04001105 RID: 4357
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001106 RID: 4358
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001107 RID: 4359
		[FieldOffset(0)]
		public IntPtr sig;

		// Token: 0x04001108 RID: 4360
		[FieldOffset(8)]
		public IntPtr args;

		// Token: 0x04001109 RID: 4361
		[FieldOffset(16)]
		public int next_arg;

		// Token: 0x0400110A RID: 4362
		[FieldOffset(20)]
		public int num_args;
	}
}
