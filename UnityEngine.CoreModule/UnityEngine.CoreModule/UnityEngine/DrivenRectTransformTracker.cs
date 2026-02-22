using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000DC RID: 220
	[StructLayout(2)]
	public struct DrivenRectTransformTracker
	{
		// Token: 0x06001302 RID: 4866 RVA: 0x00049D20 File Offset: 0x00047F20
		// Note: this type is marked as 'beforefieldinit'.
		static DrivenRectTransformTracker()
		{
			Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DrivenRectTransformTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr);
			DrivenRectTransformTracker.NativeMethodInfoPtr_Add_Public_Void_Object_RectTransform_DrivenTransformProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr, 100664594);
			DrivenRectTransformTracker.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr, 100664595);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x00049D78 File Offset: 0x00047F78
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Object driver, RectTransform rectTransform, DrivenTransformProperties drivenProperties)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(driver);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rectTransform);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref drivenProperties;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrivenRectTransformTracker.NativeMethodInfoPtr_Add_Public_Void_Object_RectTransform_DrivenTransformProperties_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x00049DD0 File Offset: 0x00047FD0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrivenRectTransformTracker.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x0000B3D9 File Offset: 0x000095D9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrivenRectTransformTracker>.NativeClassPtr, ref this));
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00049DF8 File Offset: 0x00047FF8
		public static bool CanRecordModifications()
		{
			return true;
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x0000B3EB File Offset: 0x000095EB
		public void Clear(bool revertValues)
		{
			this.Clear();
		}

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Object_RectTransform_DrivenTransformProperties_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
	}
}
