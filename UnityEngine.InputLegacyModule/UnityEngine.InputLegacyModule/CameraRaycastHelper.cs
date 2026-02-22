using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public class CameraRaycastHelper : Object
	{
		// Token: 0x0600001F RID: 31 RVA: 0x0000298C File Offset: 0x00000B8C
		// Note: this type is marked as 'beforefieldinit'.
		static CameraRaycastHelper()
		{
			Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.InputLegacyModule.dll", "UnityEngine", "CameraRaycastHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr);
			CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry_Internal_Static_GameObject_Camera_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr, 100663307);
			CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry2D_Internal_Static_GameObject_Camera_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr, 100663308);
			CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr, 100663309);
			CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry2D_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraRaycastHelper>.NativeClassPtr, 100663310);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002A0C File Offset: 0x00000C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83412, XrefRangeEnd = 83414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject RaycastTry(Camera cam, Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry_Internal_Static_GameObject_Camera_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002A7C File Offset: 0x00000C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83414, XrefRangeEnd = 83416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject RaycastTry2D(Camera cam, Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry2D_Internal_Static_GameObject_Camera_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002AEC File Offset: 0x00000CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83416, XrefRangeEnd = 83418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject RaycastTry_Injected(Camera cam, ref Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002B5C File Offset: 0x00000D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83418, XrefRangeEnd = 83420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameObject RaycastTry2D_Injected(Camera cam, ref Ray ray, float distance, int layerMask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cam);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ray;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref layerMask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraRaycastHelper.NativeMethodInfoPtr_RaycastTry2D_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020EE File Offset: 0x000002EE
		public CameraRaycastHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_RaycastTry_Internal_Static_GameObject_Camera_Ray_Single_Int32_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_RaycastTry2D_Internal_Static_GameObject_Camera_Ray_Single_Int32_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_RaycastTry_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_RaycastTry2D_Injected_Private_Static_GameObject_Camera_byref_Ray_Single_Int32_0;
	}
}
