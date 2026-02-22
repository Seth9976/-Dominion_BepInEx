using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200048D RID: 1165
	public static class IntrospectiveSortUtilities : Object
	{
		// Token: 0x060045C7 RID: 17863 RVA: 0x0013F7C0 File Offset: 0x0013D9C0
		// Note: this type is marked as 'beforefieldinit'.
		static IntrospectiveSortUtilities()
		{
			Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "IntrospectiveSortUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr);
			IntrospectiveSortUtilities.NativeMethodInfoPtr_FloorLog2_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr, 100673583);
			IntrospectiveSortUtilities.NativeMethodInfoPtr_ThrowOrIgnoreBadComparer_Internal_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntrospectiveSortUtilities>.NativeClassPtr, 100673584);
		}

		// Token: 0x060045C8 RID: 17864 RVA: 0x0013F818 File Offset: 0x0013DA18
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 361563, RefRangeEnd = 361567, XrefRangeStart = 361563, XrefRangeEnd = 361563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FloorLog2(int n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntrospectiveSortUtilities.NativeMethodInfoPtr_FloorLog2_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x0013F858 File Offset: 0x0013DA58
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 361574, RefRangeEnd = 361579, XrefRangeStart = 361567, XrefRangeEnd = 361574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowOrIgnoreBadComparer(Object comparer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntrospectiveSortUtilities.NativeMethodInfoPtr_ThrowOrIgnoreBadComparer_Internal_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x0001A96E File Offset: 0x00018B6E
		public IntrospectiveSortUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040038B9 RID: 14521
		private static readonly IntPtr NativeMethodInfoPtr_FloorLog2_Internal_Static_Int32_Int32_0;

		// Token: 0x040038BA RID: 14522
		private static readonly IntPtr NativeMethodInfoPtr_ThrowOrIgnoreBadComparer_Internal_Static_Void_Object_0;
	}
}
