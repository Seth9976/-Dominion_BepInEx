using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x0200003C RID: 60
	public class ReflectionMethodsCache : Object
	{
		// Token: 0x060007B8 RID: 1976 RVA: 0x00025260 File Offset: 0x00023460
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionMethodsCache()
		{
			Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "ReflectionMethodsCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr);
			ReflectionMethodsCache.NativeFieldInfoPtr_raycast3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "raycast3D");
			ReflectionMethodsCache.NativeFieldInfoPtr_raycast3DAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "raycast3DAll");
			ReflectionMethodsCache.NativeFieldInfoPtr_getRaycastNonAlloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "getRaycastNonAlloc");
			ReflectionMethodsCache.NativeFieldInfoPtr_raycast2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "raycast2D");
			ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "getRayIntersectionAll");
			ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAllNonAlloc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "getRayIntersectionAllNonAlloc");
			ReflectionMethodsCache.NativeFieldInfoPtr_s_ReflectionMethodsCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "s_ReflectionMethodsCache");
			ReflectionMethodsCache.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, 100664445);
			ReflectionMethodsCache.NativeMethodInfoPtr_get_Singleton_Public_Static_get_ReflectionMethodsCache_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, 100664446);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00025344 File Offset: 0x00023544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 119692, RefRangeEnd = 119693, XrefRangeStart = 119507, XrefRangeEnd = 119692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionMethodsCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x00025380 File Offset: 0x00023580
		public unsafe static ReflectionMethodsCache Singleton
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 119705, RefRangeEnd = 119717, XrefRangeStart = 119693, XrefRangeEnd = 119705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.NativeMethodInfoPtr_get_Singleton_Public_Static_get_ReflectionMethodsCache_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache>(intPtr3) : null;
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00004A35 File Offset: 0x00002C35
		public ReflectionMethodsCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x060007BC RID: 1980 RVA: 0x000253B4 File Offset: 0x000235B4
		// (set) Token: 0x060007BD RID: 1981 RVA: 0x00004A3E File Offset: 0x00002C3E
		public unsafe ReflectionMethodsCache.Raycast3DCallback raycast3D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast3D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.Raycast3DCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast3D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x000253E4 File Offset: 0x000235E4
		// (set) Token: 0x060007BF RID: 1983 RVA: 0x00004A5D File Offset: 0x00002C5D
		public unsafe ReflectionMethodsCache.RaycastAllCallback raycast3DAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast3DAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.RaycastAllCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast3DAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00025414 File Offset: 0x00023614
		// (set) Token: 0x060007C1 RID: 1985 RVA: 0x00004A7C File Offset: 0x00002C7C
		public unsafe ReflectionMethodsCache.GetRaycastNonAllocCallback getRaycastNonAlloc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRaycastNonAlloc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.GetRaycastNonAllocCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRaycastNonAlloc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00025444 File Offset: 0x00023644
		// (set) Token: 0x060007C3 RID: 1987 RVA: 0x00004A9B File Offset: 0x00002C9B
		public unsafe ReflectionMethodsCache.Raycast2DCallback raycast2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.Raycast2DCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_raycast2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00025474 File Offset: 0x00023674
		// (set) Token: 0x060007C5 RID: 1989 RVA: 0x00004ABA File Offset: 0x00002CBA
		public unsafe ReflectionMethodsCache.GetRayIntersectionAllCallback getRayIntersectionAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.GetRayIntersectionAllCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x000254A4 File Offset: 0x000236A4
		// (set) Token: 0x060007C7 RID: 1991 RVA: 0x00004AD9 File Offset: 0x00002CD9
		public unsafe ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback getRayIntersectionAllNonAlloc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAllNonAlloc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionMethodsCache.NativeFieldInfoPtr_getRayIntersectionAllNonAlloc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x000254D4 File Offset: 0x000236D4
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x00004AF8 File Offset: 0x00002CF8
		public unsafe static ReflectionMethodsCache s_ReflectionMethodsCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionMethodsCache.NativeFieldInfoPtr_s_ReflectionMethodsCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReflectionMethodsCache>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionMethodsCache.NativeFieldInfoPtr_s_ReflectionMethodsCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeFieldInfoPtr_raycast3D;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeFieldInfoPtr_raycast3DAll;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeFieldInfoPtr_getRaycastNonAlloc;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeFieldInfoPtr_raycast2D;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeFieldInfoPtr_getRayIntersectionAll;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeFieldInfoPtr_getRayIntersectionAllNonAlloc;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionMethodsCache;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_get_Singleton_Public_Static_get_ReflectionMethodsCache_0;

		// Token: 0x020000B5 RID: 181
		public sealed class Raycast3DCallback : MulticastDelegate
		{
			// Token: 0x06000C8E RID: 3214 RVA: 0x00036380 File Offset: 0x00034580
			// Note: this type is marked as 'beforefieldinit'.
			static Raycast3DCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "Raycast3DCallback");
				ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr, 100665051);
				ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Ray_byref_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr, 100665052);
				ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_byref_RaycastHit_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr, 100665053);
				ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_RaycastHit_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr, 100665054);
			}

			// Token: 0x06000C8F RID: 3215 RVA: 0x000363F4 File Offset: 0x000345F4
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Raycast3DCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast3DCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C90 RID: 3216 RVA: 0x00036450 File Offset: 0x00034650
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119409, XrefRangeEnd = 119415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Invoke(Ray r, out RaycastHit hit, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Ray_byref_RaycastHit_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C91 RID: 3217 RVA: 0x000364C4 File Offset: 0x000346C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119415, XrefRangeEnd = 119428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, out RaycastHit hit, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_byref_RaycastHit_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000C92 RID: 3218 RVA: 0x00036560 File Offset: 0x00034760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119428, XrefRangeEnd = 119430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool EndInvoke(out RaycastHit hit, IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &hit;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast3DCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_RaycastHit_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000C93 RID: 3219 RVA: 0x00006BA6 File Offset: 0x00004DA6
			public Raycast3DCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040009D9 RID: 2521
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040009DA RID: 2522
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Ray_byref_RaycastHit_Single_Int32_0;

			// Token: 0x040009DB RID: 2523
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_byref_RaycastHit_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x040009DC RID: 2524
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_RaycastHit_IAsyncResult_0;
		}

		// Token: 0x020000B6 RID: 182
		public sealed class RaycastAllCallback : MulticastDelegate
		{
			// Token: 0x06000C94 RID: 3220 RVA: 0x000365BC File Offset: 0x000347BC
			// Note: this type is marked as 'beforefieldinit'.
			static RaycastAllCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "RaycastAllCallback");
				ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr, 100665055);
				ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr, 100665056);
				ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr, 100665057);
				ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr, 100665058);
			}

			// Token: 0x06000C95 RID: 3221 RVA: 0x00036630 File Offset: 0x00034830
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaycastAllCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.RaycastAllCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C96 RID: 3222 RVA: 0x0003668C File Offset: 0x0003488C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 119436, RefRangeEnd = 119440, XrefRangeStart = 119430, XrefRangeEnd = 119436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<RaycastHit> Invoke(Ray r, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
			}

			// Token: 0x06000C97 RID: 3223 RVA: 0x000366F4 File Offset: 0x000348F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119440, XrefRangeEnd = 119450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000C98 RID: 3224 RVA: 0x00036784 File Offset: 0x00034984
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<RaycastHit> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.RaycastAllCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit>>(intPtr3) : null;
				}
			}

			// Token: 0x06000C99 RID: 3225 RVA: 0x00006BAF File Offset: 0x00004DAF
			public RaycastAllCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000C9A RID: 3226 RVA: 0x00006BB8 File Offset: 0x00004DB8
			public static implicit operator ReflectionMethodsCache.RaycastAllCallback(Func<Ray, float, int, Il2CppStructArray<RaycastHit>> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.RaycastAllCallback>(A_0);
			}

			// Token: 0x06000C9B RID: 3227 RVA: 0x00006BC0 File Offset: 0x00004DC0
			public static ReflectionMethodsCache.RaycastAllCallback operator +(ReflectionMethodsCache.RaycastAllCallback A_0, ReflectionMethodsCache.RaycastAllCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.RaycastAllCallback>();
			}

			// Token: 0x06000C9C RID: 3228 RVA: 0x00006BCE File Offset: 0x00004DCE
			public static ReflectionMethodsCache.RaycastAllCallback operator -(ReflectionMethodsCache.RaycastAllCallback A_0, ReflectionMethodsCache.RaycastAllCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.RaycastAllCallback>();
				}
				return delegate2;
			}

			// Token: 0x040009DD RID: 2525
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040009DE RID: 2526
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_Ray_Single_Int32_0;

			// Token: 0x040009DF RID: 2527
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x040009E0 RID: 2528
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit_IAsyncResult_0;
		}

		// Token: 0x020000B7 RID: 183
		public sealed class GetRaycastNonAllocCallback : MulticastDelegate
		{
			// Token: 0x06000C9D RID: 3229 RVA: 0x000367D4 File Offset: 0x000349D4
			// Note: this type is marked as 'beforefieldinit'.
			static GetRaycastNonAllocCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "GetRaycastNonAllocCallback");
				ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr, 100665059);
				ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr, 100665060);
				ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr, 100665061);
				ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr, 100665062);
			}

			// Token: 0x06000C9E RID: 3230 RVA: 0x00036848 File Offset: 0x00034A48
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetRaycastNonAllocCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.GetRaycastNonAllocCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C9F RID: 3231 RVA: 0x000368A4 File Offset: 0x00034AA4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 119456, RefRangeEnd = 119458, XrefRangeStart = 119450, XrefRangeEnd = 119456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Invoke(Ray r, Il2CppStructArray<RaycastHit> results, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000CA0 RID: 3232 RVA: 0x0003691C File Offset: 0x00034B1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119458, XrefRangeEnd = 119468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, Il2CppStructArray<RaycastHit> results, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000CA1 RID: 3233 RVA: 0x000369BC File Offset: 0x00034BBC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43352, RefRangeEnd = 43355, XrefRangeStart = 43352, XrefRangeEnd = 43355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRaycastNonAllocCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CA2 RID: 3234 RVA: 0x00006BDF File Offset: 0x00004DDF
			public GetRaycastNonAllocCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000CA3 RID: 3235 RVA: 0x00006BE8 File Offset: 0x00004DE8
			public static implicit operator ReflectionMethodsCache.GetRaycastNonAllocCallback(Func<Ray, Il2CppStructArray<RaycastHit>, float, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.GetRaycastNonAllocCallback>(A_0);
			}

			// Token: 0x06000CA4 RID: 3236 RVA: 0x00006BF0 File Offset: 0x00004DF0
			public static ReflectionMethodsCache.GetRaycastNonAllocCallback operator +(ReflectionMethodsCache.GetRaycastNonAllocCallback A_0, ReflectionMethodsCache.GetRaycastNonAllocCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.GetRaycastNonAllocCallback>();
			}

			// Token: 0x06000CA5 RID: 3237 RVA: 0x00006BFE File Offset: 0x00004DFE
			public static ReflectionMethodsCache.GetRaycastNonAllocCallback operator -(ReflectionMethodsCache.GetRaycastNonAllocCallback A_0, ReflectionMethodsCache.GetRaycastNonAllocCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.GetRaycastNonAllocCallback>();
				}
				return delegate2;
			}

			// Token: 0x040009E1 RID: 2529
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040009E2 RID: 2530
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_0;

			// Token: 0x040009E3 RID: 2531
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x040009E4 RID: 2532
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}

		// Token: 0x020000B8 RID: 184
		public sealed class Raycast2DCallback : MulticastDelegate
		{
			// Token: 0x06000CA6 RID: 3238 RVA: 0x00036A0C File Offset: 0x00034C0C
			// Note: this type is marked as 'beforefieldinit'.
			static Raycast2DCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "Raycast2DCallback");
				ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr, 100665063);
				ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_RaycastHit2D_Vector2_Vector2_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr, 100665064);
				ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2_Vector2_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr, 100665065);
				ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_RaycastHit2D_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr, 100665066);
			}

			// Token: 0x06000CA7 RID: 3239 RVA: 0x00036A80 File Offset: 0x00034C80
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Raycast2DCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.Raycast2DCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CA8 RID: 3240 RVA: 0x00036ADC File Offset: 0x00034CDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119468, XrefRangeEnd = 119473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaycastHit2D Invoke(Vector2 p1, Vector2 p2, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref p1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_RaycastHit2D_Vector2_Vector2_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000CA9 RID: 3241 RVA: 0x00036B50 File Offset: 0x00034D50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119473, XrefRangeEnd = 119485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Vector2 p1, Vector2 p2, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref p1;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p2;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2_Vector2_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000CAA RID: 3242 RVA: 0x00036BEC File Offset: 0x00034DEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119485, XrefRangeEnd = 119487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RaycastHit2D EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.Raycast2DCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_RaycastHit2D_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CAB RID: 3243 RVA: 0x00006C0F File Offset: 0x00004E0F
			public Raycast2DCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000CAC RID: 3244 RVA: 0x00006C18 File Offset: 0x00004E18
			public static implicit operator ReflectionMethodsCache.Raycast2DCallback(Func<Vector2, Vector2, float, int, RaycastHit2D> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.Raycast2DCallback>(A_0);
			}

			// Token: 0x06000CAD RID: 3245 RVA: 0x00006C20 File Offset: 0x00004E20
			public static ReflectionMethodsCache.Raycast2DCallback operator +(ReflectionMethodsCache.Raycast2DCallback A_0, ReflectionMethodsCache.Raycast2DCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.Raycast2DCallback>();
			}

			// Token: 0x06000CAE RID: 3246 RVA: 0x00006C2E File Offset: 0x00004E2E
			public static ReflectionMethodsCache.Raycast2DCallback operator -(ReflectionMethodsCache.Raycast2DCallback A_0, ReflectionMethodsCache.Raycast2DCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.Raycast2DCallback>();
				}
				return delegate2;
			}

			// Token: 0x040009E5 RID: 2533
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040009E6 RID: 2534
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_RaycastHit2D_Vector2_Vector2_Single_Int32_0;

			// Token: 0x040009E7 RID: 2535
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Vector2_Vector2_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x040009E8 RID: 2536
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_RaycastHit2D_IAsyncResult_0;
		}

		// Token: 0x020000B9 RID: 185
		public sealed class GetRayIntersectionAllCallback : MulticastDelegate
		{
			// Token: 0x06000CAF RID: 3247 RVA: 0x00036C3C File Offset: 0x00034E3C
			// Note: this type is marked as 'beforefieldinit'.
			static GetRayIntersectionAllCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "GetRayIntersectionAllCallback");
				ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr, 100665067);
				ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr, 100665068);
				ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr, 100665069);
				ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr, 100665070);
			}

			// Token: 0x06000CB0 RID: 3248 RVA: 0x00036CB0 File Offset: 0x00034EB0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetRayIntersectionAllCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CB1 RID: 3249 RVA: 0x00036D0C File Offset: 0x00034F0C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 119436, RefRangeEnd = 119440, XrefRangeStart = 119436, XrefRangeEnd = 119440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<RaycastHit2D> Invoke(Ray r, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
			}

			// Token: 0x06000CB2 RID: 3250 RVA: 0x00036D74 File Offset: 0x00034F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119487, XrefRangeEnd = 119497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000CB3 RID: 3251 RVA: 0x00036E04 File Offset: 0x00035004
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<RaycastHit2D> EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RaycastHit2D>>(intPtr3) : null;
				}
			}

			// Token: 0x06000CB4 RID: 3252 RVA: 0x00006C3F File Offset: 0x00004E3F
			public GetRayIntersectionAllCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000CB5 RID: 3253 RVA: 0x00006C48 File Offset: 0x00004E48
			public static implicit operator ReflectionMethodsCache.GetRayIntersectionAllCallback(Func<Ray, float, int, Il2CppStructArray<RaycastHit2D>> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.GetRayIntersectionAllCallback>(A_0);
			}

			// Token: 0x06000CB6 RID: 3254 RVA: 0x00006C50 File Offset: 0x00004E50
			public static ReflectionMethodsCache.GetRayIntersectionAllCallback operator +(ReflectionMethodsCache.GetRayIntersectionAllCallback A_0, ReflectionMethodsCache.GetRayIntersectionAllCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.GetRayIntersectionAllCallback>();
			}

			// Token: 0x06000CB7 RID: 3255 RVA: 0x00006C5E File Offset: 0x00004E5E
			public static ReflectionMethodsCache.GetRayIntersectionAllCallback operator -(ReflectionMethodsCache.GetRayIntersectionAllCallback A_0, ReflectionMethodsCache.GetRayIntersectionAllCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.GetRayIntersectionAllCallback>();
				}
				return delegate2;
			}

			// Token: 0x040009E9 RID: 2537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040009EA RID: 2538
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_Ray_Single_Int32_0;

			// Token: 0x040009EB RID: 2539
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x040009EC RID: 2540
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Il2CppStructArray_1_RaycastHit2D_IAsyncResult_0;
		}

		// Token: 0x020000BA RID: 186
		public sealed class GetRayIntersectionAllNonAllocCallback : MulticastDelegate
		{
			// Token: 0x06000CB8 RID: 3256 RVA: 0x00036E54 File Offset: 0x00035054
			// Note: this type is marked as 'beforefieldinit'.
			static GetRayIntersectionAllNonAllocCallback()
			{
				Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReflectionMethodsCache>.NativeClassPtr, "GetRayIntersectionAllNonAllocCallback");
				ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr, 100665071);
				ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr, 100665072);
				ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr, 100665073);
				ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr, 100665074);
			}

			// Token: 0x06000CB9 RID: 3257 RVA: 0x00036EC8 File Offset: 0x000350C8
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GetRayIntersectionAllNonAllocCallback(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000CBA RID: 3258 RVA: 0x00036F24 File Offset: 0x00035124
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 119456, RefRangeEnd = 119458, XrefRangeStart = 119456, XrefRangeEnd = 119458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Invoke(Ray r, Il2CppStructArray<RaycastHit2D> results, float f, int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000CBB RID: 3259 RVA: 0x00036F9C File Offset: 0x0003519C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 119497, XrefRangeEnd = 119507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Ray r, Il2CppStructArray<RaycastHit2D> results, float f, int i, AsyncCallback callback, Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(results);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06000CBC RID: 3260 RVA: 0x0003703C File Offset: 0x0003523C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43352, RefRangeEnd = 43355, XrefRangeStart = 43352, XrefRangeEnd = 43355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CBD RID: 3261 RVA: 0x00006C6F File Offset: 0x00004E6F
			public GetRayIntersectionAllNonAllocCallback(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06000CBE RID: 3262 RVA: 0x00006C78 File Offset: 0x00004E78
			public static implicit operator ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback(Func<Ray, Il2CppStructArray<RaycastHit2D>, float, int, int> A_0)
			{
				return DelegateSupport.ConvertDelegate<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>(A_0);
			}

			// Token: 0x06000CBF RID: 3263 RVA: 0x00006C80 File Offset: 0x00004E80
			public static ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback operator +(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback A_0, ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>();
			}

			// Token: 0x06000CC0 RID: 3264 RVA: 0x00006C8E File Offset: 0x00004E8E
			public static ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback operator -(ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback A_0, ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<ReflectionMethodsCache.GetRayIntersectionAllNonAllocCallback>();
				}
				return delegate2;
			}

			// Token: 0x040009ED RID: 2541
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040009EE RID: 2542
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Int32_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_0;

			// Token: 0x040009EF RID: 2543
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Ray_Il2CppStructArray_1_RaycastHit2D_Single_Int32_AsyncCallback_Object_0;

			// Token: 0x040009F0 RID: 2544
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Int32_IAsyncResult_0;
		}
	}
}
