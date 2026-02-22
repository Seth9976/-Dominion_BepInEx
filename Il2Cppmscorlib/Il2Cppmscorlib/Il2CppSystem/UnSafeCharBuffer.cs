using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000101 RID: 257
	[StructLayout(2)]
	public struct UnSafeCharBuffer
	{
		// Token: 0x060012D7 RID: 4823 RVA: 0x00079978 File Offset: 0x00077B78
		// Note: this type is marked as 'beforefieldinit'.
		static UnSafeCharBuffer()
		{
			Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "UnSafeCharBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr);
			UnSafeCharBuffer.NativeFieldInfoPtr_m_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr, "m_buffer");
			UnSafeCharBuffer.NativeFieldInfoPtr_m_totalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr, "m_totalSize");
			UnSafeCharBuffer.NativeFieldInfoPtr_m_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr, "m_length");
			UnSafeCharBuffer.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr, 100666580);
			UnSafeCharBuffer.NativeMethodInfoPtr_AppendString_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr, 100666581);
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x00079A0C File Offset: 0x00077C0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 303380, RefRangeEnd = 303381, XrefRangeStart = 303380, XrefRangeEnd = 303380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnSafeCharBuffer(char* buffer, int bufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = buffer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnSafeCharBuffer.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012D9 RID: 4825 RVA: 0x00079A4C File Offset: 0x00077C4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 303384, RefRangeEnd = 303387, XrefRangeStart = 303381, XrefRangeEnd = 303384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendString(string stringToAppend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToAppend);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnSafeCharBuffer.NativeMethodInfoPtr_AppendString_Public_Void_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012DA RID: 4826 RVA: 0x000067DD File Offset: 0x000049DD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnSafeCharBuffer>.NativeClassPtr, ref this));
		}

		// Token: 0x0400104A RID: 4170
		private static readonly IntPtr NativeFieldInfoPtr_m_buffer;

		// Token: 0x0400104B RID: 4171
		private static readonly IntPtr NativeFieldInfoPtr_m_totalSize;

		// Token: 0x0400104C RID: 4172
		private static readonly IntPtr NativeFieldInfoPtr_m_length;

		// Token: 0x0400104D RID: 4173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0;

		// Token: 0x0400104E RID: 4174
		private static readonly IntPtr NativeMethodInfoPtr_AppendString_Public_Void_String_0;

		// Token: 0x0400104F RID: 4175
		[FieldOffset(0)]
		public IntPtr m_buffer;

		// Token: 0x04001050 RID: 4176
		[FieldOffset(8)]
		public int m_totalSize;

		// Token: 0x04001051 RID: 4177
		[FieldOffset(12)]
		public int m_length;
	}
}
