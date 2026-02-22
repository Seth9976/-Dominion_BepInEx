using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001E RID: 30
	public class ObjectGUIState : Object
	{
		// Token: 0x0600051A RID: 1306 RVA: 0x000134A8 File Offset: 0x000116A8
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectGUIState()
		{
			Il2CppClassPointerStore<ObjectGUIState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "ObjectGUIState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectGUIState>.NativeClassPtr);
			ObjectGUIState.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectGUIState>.NativeClassPtr, "m_Ptr");
			ObjectGUIState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGUIState>.NativeClassPtr, 100663699);
			ObjectGUIState.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGUIState>.NativeClassPtr, 100663700);
			ObjectGUIState.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGUIState>.NativeClassPtr, 100663701);
			ObjectGUIState.NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGUIState>.NativeClassPtr, 100663702);
			ObjectGUIState.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGUIState>.NativeClassPtr, 100663703);
			ObjectGUIState.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectGUIState>.NativeClassPtr, 100663704);
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00013564 File Offset: 0x00011764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88266, RefRangeEnd = 88267, XrefRangeStart = 88263, XrefRangeEnd = 88266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectGUIState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectGUIState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGUIState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x000135A0 File Offset: 0x000117A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88272, RefRangeEnd = 88273, XrefRangeStart = 88267, XrefRangeEnd = 88272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGUIState.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000135D4 File Offset: 0x000117D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88273, XrefRangeEnd = 88277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectGUIState.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00013610 File Offset: 0x00011810
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88281, RefRangeEnd = 88283, XrefRangeStart = 88277, XrefRangeEnd = 88281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGUIState.NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00013644 File Offset: 0x00011844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88283, XrefRangeEnd = 88285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Internal_Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGUIState.NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00013674 File Offset: 0x00011874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88285, XrefRangeEnd = 88287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectGUIState.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000042B3 File Offset: 0x000024B3
		public ObjectGUIState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000522 RID: 1314 RVA: 0x000136A8 File Offset: 0x000118A8
		// (set) Token: 0x06000523 RID: 1315 RVA: 0x000042BC File Offset: 0x000024BC
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGUIState.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectGUIState.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Create_Private_Static_IntPtr_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;
	}
}
