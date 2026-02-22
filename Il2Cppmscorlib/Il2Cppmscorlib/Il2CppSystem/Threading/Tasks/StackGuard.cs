using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002A5 RID: 677
	public class StackGuard : Object
	{
		// Token: 0x06002DFC RID: 11772 RVA: 0x000E9314 File Offset: 0x000E7514
		// Note: this type is marked as 'beforefieldinit'.
		static StackGuard()
		{
			Il2CppClassPointerStore<StackGuard>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "StackGuard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackGuard>.NativeClassPtr);
			StackGuard.NativeFieldInfoPtr_m_inliningDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, "m_inliningDepth");
			StackGuard.NativeMethodInfoPtr_TryBeginInliningScope_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100670598);
			StackGuard.NativeMethodInfoPtr_EndInliningScope_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100670599);
			StackGuard.NativeMethodInfoPtr_CheckForSufficientStack_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100670600);
			StackGuard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackGuard>.NativeClassPtr, 100670601);
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x000E93A8 File Offset: 0x000E75A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336253, RefRangeEnd = 336254, XrefRangeStart = 336253, XrefRangeEnd = 336253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryBeginInliningScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr_TryBeginInliningScope_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x000E93E4 File Offset: 0x000E75E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 336254, RefRangeEnd = 336256, XrefRangeStart = 336254, XrefRangeEnd = 336254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInliningScope()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr_EndInliningScope_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x000E9418 File Offset: 0x000E7618
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForSufficientStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr_CheckForSufficientStack_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x000E9454 File Offset: 0x000E7654
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackGuard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackGuard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackGuard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x00010097 File Offset: 0x0000E297
		public StackGuard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x000E9490 File Offset: 0x000E7690
		// (set) Token: 0x06002E03 RID: 11779 RVA: 0x000100A0 File Offset: 0x0000E2A0
		public unsafe int m_inliningDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackGuard.NativeFieldInfoPtr_m_inliningDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackGuard.NativeFieldInfoPtr_m_inliningDepth)) = value;
			}
		}

		// Token: 0x040027FA RID: 10234
		private static readonly IntPtr NativeFieldInfoPtr_m_inliningDepth;

		// Token: 0x040027FB RID: 10235
		private static readonly IntPtr NativeMethodInfoPtr_TryBeginInliningScope_Internal_Boolean_0;

		// Token: 0x040027FC RID: 10236
		private static readonly IntPtr NativeMethodInfoPtr_EndInliningScope_Internal_Void_0;

		// Token: 0x040027FD RID: 10237
		private static readonly IntPtr NativeMethodInfoPtr_CheckForSufficientStack_Private_Boolean_0;

		// Token: 0x040027FE RID: 10238
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
