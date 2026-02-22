using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000239 RID: 569
	[StructLayout(2)]
	public struct HebrewNumberParsingContext
	{
		// Token: 0x0600264D RID: 9805 RVA: 0x000CB960 File Offset: 0x000C9B60
		// Note: this type is marked as 'beforefieldinit'.
		static HebrewNumberParsingContext()
		{
			Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "HebrewNumberParsingContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr);
			HebrewNumberParsingContext.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, "state");
			HebrewNumberParsingContext.NativeFieldInfoPtr_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, "result");
			HebrewNumberParsingContext.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, 100669524);
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x000CB9CC File Offset: 0x000C9BCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 326677, RefRangeEnd = 326680, XrefRangeStart = 326677, XrefRangeEnd = 326677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HebrewNumberParsingContext(int result)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HebrewNumberParsingContext.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x0000D26A File Offset: 0x0000B46A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HebrewNumberParsingContext>.NativeClassPtr, ref this));
		}

		// Token: 0x0400221B RID: 8731
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x0400221C RID: 8732
		private static readonly IntPtr NativeFieldInfoPtr_result;

		// Token: 0x0400221D RID: 8733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400221E RID: 8734
		[FieldOffset(0)]
		public HebrewNumber.HS state;

		// Token: 0x0400221F RID: 8735
		[FieldOffset(4)]
		public int result;
	}
}
