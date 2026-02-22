using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace SA.Foundation.Patterns
{
	// Token: 0x02000029 RID: 41
	public class SA_SingletonePrefab<T> : MonoBehaviour where T : MonoBehaviour
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00008F1C File Offset: 0x0000711C
		// Note: this type is marked as 'beforefieldinit'.
		static SA_SingletonePrefab()
		{
			Il2CppClassPointerStore<SA_SingletonePrefab<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Patterns", "SA_SingletonePrefab`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_SingletonePrefab<T>>.NativeClassPtr);
			SA_SingletonePrefab<T>.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_SingletonePrefab<T>>.NativeClassPtr, "s_instance");
			SA_SingletonePrefab<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SingletonePrefab<T>>.NativeClassPtr, 100663513);
			SA_SingletonePrefab<T>.NativeMethodInfoPtr_get_HasInstance_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SingletonePrefab<T>>.NativeClassPtr, 100663514);
			SA_SingletonePrefab<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_SingletonePrefab<T>>.NativeClassPtr, 100663515);
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000151 RID: 337 RVA: 0x00008FD8 File Offset: 0x000071D8
		public unsafe static T Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100237, XrefRangeEnd = 100310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SingletonePrefab<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000152 RID: 338 RVA: 0x00009008 File Offset: 0x00007208
		public unsafe static bool HasInstance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100310, XrefRangeEnd = 100323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SingletonePrefab<T>.NativeMethodInfoPtr_get_HasInstance_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00009038 File Offset: 0x00007238
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 99732, RefRangeEnd = 99774, XrefRangeStart = 99732, XrefRangeEnd = 99774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_SingletonePrefab()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_SingletonePrefab<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_SingletonePrefab<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000246B File Offset: 0x0000066B
		public SA_SingletonePrefab(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00009074 File Offset: 0x00007274
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00009098 File Offset: 0x00007298
		public unsafe static T s_instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_SingletonePrefab<T>.NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_s_instance = SA_SingletonePrefab<T>.NativeFieldInfoPtr_s_instance;
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

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeFieldInfoPtr_s_instance;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInstance_Public_Static_get_Boolean_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
