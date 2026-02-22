using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000041 RID: 65
	public sealed class GeometryUtility : Object
	{
		// Token: 0x06000404 RID: 1028 RVA: 0x0001F72C File Offset: 0x0001D92C
		// Note: this type is marked as 'beforefieldinit'.
		static GeometryUtility()
		{
			Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "GeometryUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr);
			GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Il2CppStructArray_1_Plane_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663494);
			GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663495);
			GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663496);
			GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663497);
			GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663498);
			GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_Il2CppStructArray_1_Plane_byref_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663499);
			GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_Il2CppStructArray_1_Plane_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeometryUtility>.NativeClassPtr, 100663500);
			GeometryUtility.Internal_CalculateBounds_InjectedDelegateField = IL2CPP.ResolveICall<GeometryUtility.Internal_CalculateBounds_InjectedDelegate>("UnityEngine.GeometryUtility::Internal_CalculateBounds_Injected");
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0001F7F8 File Offset: 0x0001D9F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 61351, RefRangeEnd = 61353, XrefRangeStart = 61341, XrefRangeEnd = 61351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<Plane> CalculateFrustumPlanes(Camera camera)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Il2CppStructArray_1_Plane_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Plane>>(intPtr3) : null;
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0001F83C File Offset: 0x0001DA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61353, XrefRangeEnd = 61360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateFrustumPlanes(Camera camera, Il2CppStructArray<Plane> planes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0001F884 File Offset: 0x0001DA84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61360, XrefRangeEnd = 61362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Il2CppStructArray<Plane> planes)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref worldToProjectionMatrix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(planes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0001F8C8 File Offset: 0x0001DAC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 61364, RefRangeEnd = 61366, XrefRangeStart = 61362, XrefRangeEnd = 61364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TestPlanesAABB(Il2CppStructArray<Plane> planes, Bounds bounds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0001F918 File Offset: 0x0001DB18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61366, XrefRangeEnd = 61368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ExtractPlanes([Out] Il2CppStructArray<Plane> planes, Matrix4x4 worldToProjectionMatrix)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldToProjectionMatrix;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*planes = ((intPtr4 == 0) ? null : new Il2CppStructArray<Plane>(intPtr4));
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0001F96C File Offset: 0x0001DB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61368, XrefRangeEnd = 61370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TestPlanesAABB_Injected(Il2CppStructArray<Plane> planes, ref Bounds bounds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(planes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &bounds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_Il2CppStructArray_1_Plane_byref_Bounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0001F9BC File Offset: 0x0001DBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 61370, XrefRangeEnd = 61372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_ExtractPlanes_Injected([Out] Il2CppStructArray<Plane> planes, ref Matrix4x4 worldToProjectionMatrix)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &worldToProjectionMatrix;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GeometryUtility.NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_Il2CppStructArray_1_Plane_byref_Matrix4x4_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*planes = ((intPtr4 == 0) ? null : new Il2CppStructArray<Plane>(intPtr4));
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00004885 File Offset: 0x00002A85
		public GeometryUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000488E File Offset: 0x00002A8E
		public static Il2CppStructArray<Plane> CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0001FA10 File Offset: 0x0001DC10
		public static Bounds CalculateBounds(Il2CppStructArray<Vector3> positions, Matrix4x4 transform)
		{
			bool flag = positions == null;
			if (flag)
			{
				throw new ArgumentNullException("positions");
			}
			bool flag2 = positions.Length == 0;
			if (flag2)
			{
				throw new ArgumentException("Zero-sized array is not allowed.", "positions");
			}
			return GeometryUtility.Internal_CalculateBounds(positions, transform);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0001FA5C File Offset: 0x0001DC5C
		public static bool TryCreatePlaneFromPolygon(Il2CppStructArray<Vector3> vertices, out Plane plane)
		{
			bool flag = vertices == null || vertices.Length < 3;
			bool flag2;
			if (flag)
			{
				plane = new Plane(Vector3.up, 0f);
				flag2 = false;
			}
			else
			{
				bool flag3 = vertices.Length == 3;
				if (flag3)
				{
					Vector3 vector = vertices[0];
					Vector3 vector2 = vertices[1];
					Vector3 vector3 = vertices[2];
					plane = new Plane(vector, vector2, vector3);
					flag2 = plane.normal.sqrMagnitude > 0f;
				}
				else
				{
					Vector3 zero = Vector3.zero;
					int num = vertices.Length - 1;
					Vector3 vector4 = vertices[num];
					for (int i = 0; i < vertices.Length; i++)
					{
						Vector3 vector5 = vertices[i];
						zero.x += (vector4.y - vector5.y) * (vector4.z + vector5.z);
						zero.y += (vector4.z - vector5.z) * (vector4.x + vector5.x);
						zero.z += (vector4.x - vector5.x) * (vector4.y + vector5.y);
						vector4 = vector5;
					}
					zero.Normalize();
					float num2 = 0f;
					for (int j = 0; j < vertices.Length; j++)
					{
						Vector3 vector6 = vertices[j];
						num2 -= Vector3.Dot(zero, vector6);
					}
					num2 /= (float)vertices.Length;
					plane = new Plane(zero, num2);
					flag2 = plane.normal.sqrMagnitude > 0f;
				}
			}
			return flag2;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0001FC38 File Offset: 0x0001DE38
		public static Bounds Internal_CalculateBounds(Il2CppStructArray<Vector3> positions, Matrix4x4 transform)
		{
			Bounds bounds;
			GeometryUtility.Internal_CalculateBounds_Injected(positions, ref transform, out bounds);
			return bounds;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x0000489B File Offset: 0x00002A9B
		public static void Internal_CalculateBounds_Injected(Il2CppStructArray<Vector3> positions, ref Matrix4x4 transform, out Bounds ret)
		{
			GeometryUtility.Internal_CalculateBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtr(positions), ref transform, out ret);
		}

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Il2CppStructArray_1_Plane_Camera_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Camera_Il2CppStructArray_1_Plane_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFrustumPlanes_Public_Static_Void_Matrix4x4_Il2CppStructArray_1_Plane_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_TestPlanesAABB_Public_Static_Boolean_Il2CppStructArray_1_Plane_Bounds_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ExtractPlanes_Private_Static_Void_Il2CppStructArray_1_Plane_Matrix4x4_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_TestPlanesAABB_Injected_Private_Static_Boolean_Il2CppStructArray_1_Plane_byref_Bounds_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_Internal_ExtractPlanes_Injected_Private_Static_Void_Il2CppStructArray_1_Plane_byref_Matrix4x4_0;

		// Token: 0x040002CF RID: 719
		private static readonly GeometryUtility.Internal_CalculateBounds_InjectedDelegate Internal_CalculateBounds_InjectedDelegateField;

		// Token: 0x02000437 RID: 1079
		// (Invoke) Token: 0x06002635 RID: 9781
		private delegate void Internal_CalculateBounds_InjectedDelegate(IntPtr positions, IntPtr transform, [Out] IntPtr ret);
	}
}
