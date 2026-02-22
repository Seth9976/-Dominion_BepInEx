using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace SA.Common.Pattern
{
	// Token: 0x0200030F RID: 783
	public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
	{
		// Token: 0x06002D2C RID: 11564 RVA: 0x000C0C60 File Offset: 0x000BEE60
		// Note: this type is marked as 'beforefieldinit'.
		static Singleton()
		{
			Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Pattern", "Singleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr);
			Singleton<T>.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, "_instance");
			Singleton<T>.NativeFieldInfoPtr_applicationIsQuitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, "applicationIsQuitting");
			Singleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100669192);
			Singleton<T>.NativeMethodInfoPtr_get_HasInstance_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100669193);
			Singleton<T>.NativeMethodInfoPtr_get_IsDestroyed_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100669194);
			Singleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100669195);
			Singleton<T>.NativeMethodInfoPtr_OnApplicationQuit_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100669196);
			Singleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr, 100669197);
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002D2D RID: 11565 RVA: 0x000C0D6C File Offset: 0x000BEF6C
		public unsafe static T Instance
		{
			[CallerCount(393)]
			[CachedScanResults(RefRangeStart = 211688, RefRangeEnd = 212081, XrefRangeStart = 211607, XrefRangeEnd = 211688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002D2E RID: 11566 RVA: 0x000C0D9C File Offset: 0x000BEF9C
		public unsafe static bool HasInstance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212081, XrefRangeEnd = 212091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr_get_HasInstance_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06002D2F RID: 11567 RVA: 0x000C0DCC File Offset: 0x000BEFCC
		public unsafe static bool IsDestroyed
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 212104, RefRangeEnd = 212106, XrefRangeStart = 212091, XrefRangeEnd = 212104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr_get_IsDestroyed_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x000C0DFC File Offset: 0x000BEFFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100236, RefRangeEnd = 100237, XrefRangeStart = 100236, XrefRangeEnd = 100237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Singleton<T>.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x000C0E38 File Offset: 0x000BF038
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 100236, RefRangeEnd = 100237, XrefRangeStart = 100236, XrefRangeEnd = 100237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnApplicationQuit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Singleton<T>.NativeMethodInfoPtr_OnApplicationQuit_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x000C0E74 File Offset: 0x000BF074
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 99732, RefRangeEnd = 99774, XrefRangeStart = 99732, XrefRangeEnd = 99774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Singleton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Singleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Singleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D33 RID: 11571 RVA: 0x000118EC File Offset: 0x0000FAEC
		public Singleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06002D34 RID: 11572 RVA: 0x000C0EB0 File Offset: 0x000BF0B0
		// (set) Token: 0x06002D35 RID: 11573 RVA: 0x000C0ED4 File Offset: 0x000BF0D4
		public unsafe static T _instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Singleton<T>.NativeFieldInfoPtr__instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr__instance = Singleton<T>.NativeFieldInfoPtr__instance;
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
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr__instance, (void*)(&ptr2));
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06002D36 RID: 11574 RVA: 0x000C0F3C File Offset: 0x000BF13C
		// (set) Token: 0x06002D37 RID: 11575 RVA: 0x000118F5 File Offset: 0x0000FAF5
		public unsafe static bool applicationIsQuitting
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Singleton<T>.NativeFieldInfoPtr_applicationIsQuitting, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Singleton<T>.NativeFieldInfoPtr_applicationIsQuitting, (void*)(&value));
			}
		}

		// Token: 0x04002B33 RID: 11059
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x04002B34 RID: 11060
		private static readonly IntPtr NativeFieldInfoPtr_applicationIsQuitting;

		// Token: 0x04002B35 RID: 11061
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x04002B36 RID: 11062
		private static readonly IntPtr NativeMethodInfoPtr_get_HasInstance_Public_Static_get_Boolean_0;

		// Token: 0x04002B37 RID: 11063
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDestroyed_Public_Static_get_Boolean_0;

		// Token: 0x04002B38 RID: 11064
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x04002B39 RID: 11065
		private static readonly IntPtr NativeMethodInfoPtr_OnApplicationQuit_Protected_Virtual_New_Void_0;

		// Token: 0x04002B3A RID: 11066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
