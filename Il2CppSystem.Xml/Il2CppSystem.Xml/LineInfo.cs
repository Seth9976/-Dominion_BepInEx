using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000047 RID: 71
	[StructLayout(2)]
	public struct LineInfo
	{
		// Token: 0x06000604 RID: 1540 RVA: 0x00022928 File Offset: 0x00020B28
		// Note: this type is marked as 'beforefieldinit'.
		static LineInfo()
		{
			Il2CppClassPointerStore<LineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "LineInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineInfo>.NativeClassPtr);
			LineInfo.NativeFieldInfoPtr_lineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "lineNo");
			LineInfo.NativeFieldInfoPtr_linePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "linePos");
			LineInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, 100664286);
			LineInfo.NativeMethodInfoPtr_Set_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, 100664287);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x000229A8 File Offset: 0x00020BA8
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 16465, RefRangeEnd = 16495, XrefRangeStart = 16465, XrefRangeEnd = 16465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LineInfo(int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x000229E8 File Offset: 0x00020BE8
		[CallerCount(30)]
		[CachedScanResults(RefRangeStart = 16465, RefRangeEnd = 16495, XrefRangeStart = 16465, XrefRangeEnd = 16495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineInfo.NativeMethodInfoPtr_Set_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00003FE0 File Offset: 0x000021E0
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x040004A6 RID: 1190
		private static readonly IntPtr NativeFieldInfoPtr_lineNo;

		// Token: 0x040004A7 RID: 1191
		private static readonly IntPtr NativeFieldInfoPtr_linePos;

		// Token: 0x040004A8 RID: 1192
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040004A9 RID: 1193
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_Int32_0;

		// Token: 0x040004AA RID: 1194
		[FieldOffset(0)]
		public int lineNo;

		// Token: 0x040004AB RID: 1195
		[FieldOffset(4)]
		public int linePos;
	}
}
