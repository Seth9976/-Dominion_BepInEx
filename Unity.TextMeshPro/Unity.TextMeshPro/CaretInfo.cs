using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace TMPro
{
	// Token: 0x0200006F RID: 111
	[StructLayout(2)]
	public struct CaretInfo
	{
		// Token: 0x06000E0F RID: 3599 RVA: 0x00038FC4 File Offset: 0x000371C4
		// Note: this type is marked as 'beforefieldinit'.
		static CaretInfo()
		{
			Il2CppClassPointerStore<CaretInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "CaretInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr);
			CaretInfo.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr, "index");
			CaretInfo.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr, "position");
			CaretInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_CaretPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr, 100664729);
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00039030 File Offset: 0x00037230
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 16465, RefRangeEnd = 16495, XrefRangeStart = 16465, XrefRangeEnd = 16495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CaretInfo(int index, CaretPosition position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CaretInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_CaretPosition_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00008A7C File Offset: 0x00006C7C
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CaretInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_CaretPosition_0;

		// Token: 0x04000B2B RID: 2859
		[FieldOffset(0)]
		public int index;

		// Token: 0x04000B2C RID: 2860
		[FieldOffset(4)]
		public CaretPosition position;
	}
}
