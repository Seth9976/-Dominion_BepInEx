using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Foundation.Config;

namespace SA.Foundation.Patterns
{
	// Token: 0x02000026 RID: 38
	public class SA_ScriptableSingleton<T> : SA_ScriptableSettings where T : SA_ScriptableSettings
	{
		// Token: 0x0600012C RID: 300 RVA: 0x00008548 File Offset: 0x00006748
		// Note: this type is marked as 'beforefieldinit'.
		static SA_ScriptableSingleton()
		{
			Il2CppClassPointerStore<SA_ScriptableSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Patterns", "SA_ScriptableSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_ScriptableSingleton<T>>.NativeClassPtr);
			SA_ScriptableSingleton<T>.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_ScriptableSingleton<T>>.NativeClassPtr, "s_instance");
			SA_ScriptableSingleton<T>.NativeMethodInfoPtr_get_FormattedVersion_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingleton<T>>.NativeClassPtr, 100663488);
			SA_ScriptableSingleton<T>.NativeMethodInfoPtr_get_PluginVersion_Public_Static_get_PluginVersionHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingleton<T>>.NativeClassPtr, 100663489);
			SA_ScriptableSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingleton<T>>.NativeClassPtr, 100663490);
			SA_ScriptableSingleton<T>.NativeMethodInfoPtr_Save_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingleton<T>>.NativeClassPtr, 100663491);
			SA_ScriptableSingleton<T>.NativeMethodInfoPtr_get_Version_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingleton<T>>.NativeClassPtr, 100663492);
			SA_ScriptableSingleton<T>.NativeMethodInfoPtr_UpdateVersion_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingleton<T>>.NativeClassPtr, 100663493);
			SA_ScriptableSingleton<T>.NativeMethodInfoPtr_Delete_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingleton<T>>.NativeClassPtr, 100663494);
			SA_ScriptableSingleton<T>.NativeMethodInfoPtr_SaveToAssetDatabase_Private_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingleton<T>>.NativeClassPtr, 100663495);
			SA_ScriptableSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_ScriptableSingleton<T>>.NativeClassPtr, 100663496);
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000867C File Offset: 0x0000687C
		public unsafe static string FormattedVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99814, XrefRangeEnd = 99826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingleton<T>.NativeMethodInfoPtr_get_FormattedVersion_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600012E RID: 302 RVA: 0x000086A8 File Offset: 0x000068A8
		public unsafe static PluginVersionHandler PluginVersion
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99826, XrefRangeEnd = 99838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingleton<T>.NativeMethodInfoPtr_get_PluginVersion_Public_Static_get_PluginVersionHandler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PluginVersionHandler>(intPtr3) : null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000086DC File Offset: 0x000068DC
		public unsafe static T Instance
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 99904, RefRangeEnd = 99926, XrefRangeStart = 99838, XrefRangeEnd = 99904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000870C File Offset: 0x0000690C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99926, XrefRangeEnd = 99937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Save()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingleton<T>.NativeMethodInfoPtr_Save_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00008734 File Offset: 0x00006934
		public unsafe static string Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99937, XrefRangeEnd = 99947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingleton<T>.NativeMethodInfoPtr_get_Version_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00008760 File Offset: 0x00006960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99947, XrefRangeEnd = 99969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateVersion(string vercioncCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(vercioncCode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingleton<T>.NativeMethodInfoPtr_UpdateVersion_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000087A4 File Offset: 0x000069A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99969, XrefRangeEnd = 99981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Delete()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingleton<T>.NativeMethodInfoPtr_Delete_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000087CC File Offset: 0x000069CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99981, XrefRangeEnd = 99989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingleton<T>.NativeMethodInfoPtr_SaveToAssetDatabase_Private_Static_Void_T_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00008838 File Offset: 0x00006A38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 99991, RefRangeEnd = 99992, XrefRangeStart = 99989, XrefRangeEnd = 99991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_ScriptableSingleton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_ScriptableSingleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_ScriptableSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002442 File Offset: 0x00000642
		public SA_ScriptableSingleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00008874 File Offset: 0x00006A74
		// (set) Token: 0x06000138 RID: 312 RVA: 0x00008898 File Offset: 0x00006A98
		public unsafe static T s_instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_ScriptableSingleton<T>.NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_s_instance = SA_ScriptableSingleton<T>.NativeFieldInfoPtr_s_instance;
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

		// Token: 0x040000DB RID: 219
		private static readonly IntPtr NativeFieldInfoPtr_s_instance;

		// Token: 0x040000DC RID: 220
		private static readonly IntPtr NativeMethodInfoPtr_get_FormattedVersion_Public_Static_get_String_0;

		// Token: 0x040000DD RID: 221
		private static readonly IntPtr NativeMethodInfoPtr_get_PluginVersion_Public_Static_get_PluginVersionHandler_0;

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Static_Void_0;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Static_get_String_0;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVersion_Public_Static_Boolean_String_0;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Static_Void_0;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_SaveToAssetDatabase_Private_Static_Void_T_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
