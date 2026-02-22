using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace SA.Foundation.Patterns
{
	// Token: 0x02000028 RID: 40
	public class SA_Singleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00008B98 File Offset: 0x00006D98
		// Note: this type is marked as 'beforefieldinit'.
		static SA_Singleton()
		{
			Il2CppClassPointerStore<SA_Singleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Patterns", "SA_Singleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Singleton<T>>.NativeClassPtr);
			SA_Singleton<T>.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Singleton<T>>.NativeClassPtr, "s_instance");
			SA_Singleton<T>.NativeFieldInfoPtr_s_applicationIsQuitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Singleton<T>>.NativeClassPtr, "s_applicationIsQuitting");
			SA_Singleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Singleton<T>>.NativeClassPtr, 100663504);
			SA_Singleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Singleton<T>>.NativeClassPtr, 100663505);
			SA_Singleton<T>.NativeMethodInfoPtr_Instantiate_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Singleton<T>>.NativeClassPtr, 100663506);
			SA_Singleton<T>.NativeMethodInfoPtr_get_HasInstance_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Singleton<T>>.NativeClassPtr, 100663507);
			SA_Singleton<T>.NativeMethodInfoPtr_get_IsDestroyed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Singleton<T>>.NativeClassPtr, 100663508);
			SA_Singleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Singleton<T>>.NativeClassPtr, 100663509);
			SA_Singleton<T>.NativeMethodInfoPtr_OnApplicationQuit_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Singleton<T>>.NativeClassPtr, 100663510);
			SA_Singleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Singleton<T>>.NativeClassPtr, 100663511);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00008CCC File Offset: 0x00006ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100102, RefRangeEnd = 100103, XrefRangeStart = 100089, XrefRangeEnd = 100102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_Singleton<T>.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00008D08 File Offset: 0x00006F08
		public unsafe static T Instance
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 100173, RefRangeEnd = 100186, XrefRangeStart = 100103, XrefRangeEnd = 100173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Singleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00008D38 File Offset: 0x00006F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100186, XrefRangeEnd = 100207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Instantiate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Singleton<T>.NativeMethodInfoPtr_Instantiate_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00008D60 File Offset: 0x00006F60
		public unsafe static bool HasInstance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 100217, RefRangeEnd = 100218, XrefRangeStart = 100207, XrefRangeEnd = 100217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Singleton<T>.NativeMethodInfoPtr_get_HasInstance_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000147 RID: 327 RVA: 0x00008D90 File Offset: 0x00006F90
		public unsafe static bool IsDestroyed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100218, XrefRangeEnd = 100231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Singleton<T>.NativeMethodInfoPtr_get_IsDestroyed_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00008DC0 File Offset: 0x00006FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100236, RefRangeEnd = 100237, XrefRangeStart = 100231, XrefRangeEnd = 100236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_Singleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00008DFC File Offset: 0x00006FFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100236, RefRangeEnd = 100237, XrefRangeStart = 100236, XrefRangeEnd = 100237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SA_Singleton<T>.NativeMethodInfoPtr_OnApplicationQuit_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00008E38 File Offset: 0x00007038
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 99732, RefRangeEnd = 99774, XrefRangeStart = 99732, XrefRangeEnd = 99774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_Singleton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Singleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Singleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002454 File Offset: 0x00000654
		public SA_Singleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600014C RID: 332 RVA: 0x00008E74 File Offset: 0x00007074
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00008E98 File Offset: 0x00007098
		public unsafe static T s_instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Singleton<T>.NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_s_instance = SA_Singleton<T>.NativeFieldInfoPtr_s_instance;
				ref T ptr2;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr = (ptr2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr) != null)
						{
							ptr2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_s_instance, (void*)(&ptr2));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600014E RID: 334 RVA: 0x00008F00 File Offset: 0x00007100
		// (set) Token: 0x0600014F RID: 335 RVA: 0x0000245D File Offset: 0x0000065D
		public unsafe static bool s_applicationIsQuitting
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SA_Singleton<T>.NativeFieldInfoPtr_s_applicationIsQuitting, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Singleton<T>.NativeFieldInfoPtr_s_applicationIsQuitting, (void*)(&value));
			}
		}

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr_s_instance;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr_s_applicationIsQuitting;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_Static_Void_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInstance_Public_Static_get_Boolean_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Static_get_Boolean_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Protected_Virtual_New_Void_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
