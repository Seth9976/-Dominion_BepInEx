using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace SA.Foundation.Patterns
{
	// Token: 0x02000024 RID: 36
	public class SA_SceneSingleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		// Token: 0x06000118 RID: 280 RVA: 0x00008064 File Offset: 0x00006264
		// Note: this type is marked as 'beforefieldinit'.
		static SA_SceneSingleton()
		{
			Il2CppClassPointerStore<SA_SceneSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Patterns", "SA_SceneSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_SceneSingleton<T>>.NativeClassPtr);
			SA_SceneSingleton<T>.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_SceneSingleton<T>>.NativeClassPtr, "s_instance");
			SA_SceneSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneSingleton<T>>.NativeClassPtr, 100663477);
			SA_SceneSingleton<T>.NativeMethodInfoPtr_get_HasInstance_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneSingleton<T>>.NativeClassPtr, 100663478);
			SA_SceneSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SceneSingleton<T>>.NativeClassPtr, 100663479);
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00008120 File Offset: 0x00006320
		public unsafe static T Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99645, XrefRangeEnd = 99717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00008150 File Offset: 0x00006350
		public unsafe static bool HasInstance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99717, XrefRangeEnd = 99730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneSingleton<T>.NativeMethodInfoPtr_get_HasInstance_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00008180 File Offset: 0x00006380
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 99732, RefRangeEnd = 99774, XrefRangeStart = 99730, XrefRangeEnd = 99732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_SceneSingleton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_SceneSingleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SceneSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000023F2 File Offset: 0x000005F2
		public SA_SceneSingleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600011D RID: 285 RVA: 0x000081BC File Offset: 0x000063BC
		// (set) Token: 0x0600011E RID: 286 RVA: 0x000081E0 File Offset: 0x000063E0
		public unsafe static T s_instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_SceneSingleton<T>.NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_s_instance = SA_SceneSingleton<T>.NativeFieldInfoPtr_s_instance;
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

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeFieldInfoPtr_s_instance;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInstance_Public_Static_get_Boolean_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
