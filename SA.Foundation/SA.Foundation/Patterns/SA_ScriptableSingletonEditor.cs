using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace SA.Foundation.Patterns
{
	// Token: 0x02000027 RID: 39
	public class SA_ScriptableSingletonEditor<T> : SA_ScriptableSettings where T : ScriptableObject
	{
		// Token: 0x06000139 RID: 313 RVA: 0x00008900 File Offset: 0x00006B00
		// Note: this type is marked as 'beforefieldinit'.
		static SA_ScriptableSingletonEditor()
		{
			Il2CppClassPointerStore<SA_ScriptableSingletonEditor<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Patterns", "SA_ScriptableSingletonEditor`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_ScriptableSingletonEditor<T>>.NativeClassPtr);
			SA_ScriptableSingletonEditor<T>.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ScriptableSingletonEditor<T>>.NativeClassPtr, "s_instance");
			SA_ScriptableSingletonEditor<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingletonEditor<T>>.NativeClassPtr, 100663498);
			SA_ScriptableSingletonEditor<T>.NativeMethodInfoPtr_Save_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingletonEditor<T>>.NativeClassPtr, 100663499);
			SA_ScriptableSingletonEditor<T>.NativeMethodInfoPtr_Delete_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingletonEditor<T>>.NativeClassPtr, 100663500);
			SA_ScriptableSingletonEditor<T>.NativeMethodInfoPtr_SaveToAssetDatabase_Private_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingletonEditor<T>>.NativeClassPtr, 100663501);
			SA_ScriptableSingletonEditor<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingletonEditor<T>>.NativeClassPtr, 100663502);
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000089E4 File Offset: 0x00006BE4
		public unsafe static T Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99992, XrefRangeEnd = 100058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingletonEditor<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00008A14 File Offset: 0x00006C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100058, XrefRangeEnd = 100069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Save()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingletonEditor<T>.NativeMethodInfoPtr_Save_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00008A3C File Offset: 0x00006C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100069, XrefRangeEnd = 100081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Delete()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingletonEditor<T>.NativeMethodInfoPtr_Delete_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00008A64 File Offset: 0x00006C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100081, XrefRangeEnd = 100089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SaveToAssetDatabase(T asset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = asset;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref asset;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingletonEditor<T>.NativeMethodInfoPtr_SaveToAssetDatabase_Private_Static_Void_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00008AD0 File Offset: 0x00006CD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99991, RefRangeEnd = 99992, XrefRangeStart = 99991, XrefRangeEnd = 99992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_ScriptableSingletonEditor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_ScriptableSingletonEditor<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingletonEditor<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000244B File Offset: 0x0000064B
		public SA_ScriptableSingletonEditor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00008B0C File Offset: 0x00006D0C
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00008B30 File Offset: 0x00006D30
		public unsafe static T s_instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_ScriptableSingletonEditor<T>.NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_s_instance = SA_ScriptableSingletonEditor<T>.NativeFieldInfoPtr_s_instance;
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

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_s_instance;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_SaveToAssetDatabase_Private_Static_Void_T_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
