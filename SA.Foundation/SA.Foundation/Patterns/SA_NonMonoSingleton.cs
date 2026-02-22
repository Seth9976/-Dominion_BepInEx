using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace SA.Foundation.Patterns
{
	// Token: 0x02000023 RID: 35
	public class SA_NonMonoSingleton<T> : Object where T : SA_NonMonoSingleton<T>, new()
	{
		// Token: 0x06000112 RID: 274 RVA: 0x00007EC4 File Offset: 0x000060C4
		// Note: this type is marked as 'beforefieldinit'.
		static SA_NonMonoSingleton()
		{
			Il2CppClassPointerStore<SA_NonMonoSingleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Patterns", "SA_NonMonoSingleton`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_NonMonoSingleton<T>>.NativeClassPtr);
			SA_NonMonoSingleton<T>.NativeFieldInfoPtr__Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_NonMonoSingleton<T>>.NativeClassPtr, "_Instance");
			SA_NonMonoSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_NonMonoSingleton<T>>.NativeClassPtr, 100663474);
			SA_NonMonoSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_NonMonoSingleton<T>>.NativeClassPtr, 100663475);
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00007F6C File Offset: 0x0000616C
		public unsafe static T Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99616, XrefRangeEnd = 99645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_NonMonoSingleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00007F9C File Offset: 0x0000619C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_NonMonoSingleton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_NonMonoSingleton<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_NonMonoSingleton<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000023E9 File Offset: 0x000005E9
		public SA_NonMonoSingleton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00007FD8 File Offset: 0x000061D8
		// (set) Token: 0x06000117 RID: 279 RVA: 0x00007FFC File Offset: 0x000061FC
		public unsafe static T _Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_NonMonoSingleton<T>.NativeFieldInfoPtr__Instance, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr__Instance = SA_NonMonoSingleton<T>.NativeFieldInfoPtr__Instance;
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
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr__Instance, (void*)(&ptr2));
			}
		}

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeFieldInfoPtr__Instance;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
