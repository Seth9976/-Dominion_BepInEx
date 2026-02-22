using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace SA.Foundation.Async
{
	// Token: 0x0200003F RID: 63
	public static class SA_AsyncLoader : global::Il2CppSystem.Object
	{
		// Token: 0x0600037E RID: 894 RVA: 0x00011D24 File Offset: 0x0000FF24
		// Note: this type is marked as 'beforefieldinit'.
		static SA_AsyncLoader()
		{
			Il2CppClassPointerStore<SA_AsyncLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Async", "SA_AsyncLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_AsyncLoader>.NativeClassPtr);
			SA_AsyncLoader.NativeMethodInfoPtr_LoadResource_Public_Static_Void_String_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader>.NativeClassPtr, 100663840);
			SA_AsyncLoader.NativeMethodInfoPtr_ResourceLoadCoroutine_Private_Static_IEnumerator_String_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader>.NativeClassPtr, 100663841);
			SA_AsyncLoader.NativeMethodInfoPtr_LoadTexture_Public_Static_Void_String_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader>.NativeClassPtr, 100663842);
			SA_AsyncLoader.NativeMethodInfoPtr_ResourceLoadTextureCoroutine_Private_Static_IEnumerator_String_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader>.NativeClassPtr, 100663843);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00011DA4 File Offset: 0x0000FFA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107608, XrefRangeEnd = 107609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadResource<T>(string path, Action<T> callback) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader.MethodInfoStoreGeneric_LoadResource_Public_Static_Void_String_Action_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00011DEC File Offset: 0x0000FFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107609, XrefRangeEnd = 107611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator ResourceLoadCoroutine<T>(string path, Action<T> callback) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader.MethodInfoStoreGeneric_ResourceLoadCoroutine_Private_Static_IEnumerator_String_Action_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00011E44 File Offset: 0x00010044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LoadTexture<T>(string path, Action<T> callback) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader.MethodInfoStoreGeneric_LoadTexture_Public_Static_Void_String_Action_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00011E8C File Offset: 0x0001008C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator ResourceLoadTextureCoroutine<T>(string path, Action<T> callback) where T : global::UnityEngine.Object
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader.MethodInfoStoreGeneric_ResourceLoadTextureCoroutine_Private_Static_IEnumerator_String_Action_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00002EA2 File Offset: 0x000010A2
		public SA_AsyncLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_LoadResource_Public_Static_Void_String_Action_1_T_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_ResourceLoadCoroutine_Private_Static_IEnumerator_String_Action_1_T_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_LoadTexture_Public_Static_Void_String_Action_1_T_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_ResourceLoadTextureCoroutine_Private_Static_IEnumerator_String_Action_1_T_0;

		// Token: 0x0200005B RID: 91
		[ObfuscatedName("SA.Foundation.Async.SA_AsyncLoader+<ResourceLoadCoroutine>d__1`1")]
		public sealed class _ResourceLoadCoroutine_d__1<T> : global::Il2CppSystem.Object where T : global::UnityEngine.Object
		{
			// Token: 0x0600046E RID: 1134 RVA: 0x00014B48 File Offset: 0x00012D48
			// Note: this type is marked as 'beforefieldinit'.
			static _ResourceLoadCoroutine_d__1()
			{
				Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_AsyncLoader>.NativeClassPtr, "<ResourceLoadCoroutine>d__1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr);
				SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr, "<>1__state");
				SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr, "<>2__current");
				SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr, "path");
				SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr, "callback");
				SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr, "<request>5__2");
				SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr, 100663928);
				SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr, 100663929);
				SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr, 100663930);
				SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr, 100663931);
				SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr, 100663932);
				SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr, 100663933);
			}

			// Token: 0x0600046F RID: 1135 RVA: 0x00014C8C File Offset: 0x00012E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResourceLoadCoroutine_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000470 RID: 1136 RVA: 0x00014CD4 File Offset: 0x00012ED4
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000471 RID: 1137 RVA: 0x00014D08 File Offset: 0x00012F08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107586, XrefRangeEnd = 107592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000EF RID: 239
			// (get) Token: 0x06000472 RID: 1138 RVA: 0x00014D44 File Offset: 0x00012F44
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000473 RID: 1139 RVA: 0x00014D84 File Offset: 0x00012F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107592, XrefRangeEnd = 107597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000F0 RID: 240
			// (get) Token: 0x06000474 RID: 1140 RVA: 0x00014DB8 File Offset: 0x00012FB8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000475 RID: 1141 RVA: 0x000034A3 File Offset: 0x000016A3
			public _ResourceLoadCoroutine_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x06000476 RID: 1142 RVA: 0x00014DF8 File Offset: 0x00012FF8
			// (set) Token: 0x06000477 RID: 1143 RVA: 0x000034AC File Offset: 0x000016AC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000EB RID: 235
			// (get) Token: 0x06000478 RID: 1144 RVA: 0x00014E20 File Offset: 0x00013020
			// (set) Token: 0x06000479 RID: 1145 RVA: 0x000034C7 File Offset: 0x000016C7
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EC RID: 236
			// (get) Token: 0x0600047A RID: 1146 RVA: 0x00014E50 File Offset: 0x00013050
			// (set) Token: 0x0600047B RID: 1147 RVA: 0x000034E6 File Offset: 0x000016E6
			public unsafe string path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000ED RID: 237
			// (get) Token: 0x0600047C RID: 1148 RVA: 0x00014E78 File Offset: 0x00013078
			// (set) Token: 0x0600047D RID: 1149 RVA: 0x00003505 File Offset: 0x00001705
			public unsafe Action<T> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000EE RID: 238
			// (get) Token: 0x0600047E RID: 1150 RVA: 0x00014EA8 File Offset: 0x000130A8
			// (set) Token: 0x0600047F RID: 1151 RVA: 0x00003524 File Offset: 0x00001724
			public unsafe ResourceRequest _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadCoroutine_d__1<T>.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000354 RID: 852
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000355 RID: 853
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000356 RID: 854
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04000357 RID: 855
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04000358 RID: 856
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04000359 RID: 857
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400035A RID: 858
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400035B RID: 859
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400035C RID: 860
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400035D RID: 861
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400035E RID: 862
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200005C RID: 92
		[ObfuscatedName("SA.Foundation.Async.SA_AsyncLoader+<ResourceLoadTextureCoroutine>d__3`1")]
		public sealed class _ResourceLoadTextureCoroutine_d__3<T> : global::Il2CppSystem.Object where T : global::UnityEngine.Object
		{
			// Token: 0x06000480 RID: 1152 RVA: 0x00014ED8 File Offset: 0x000130D8
			// Note: this type is marked as 'beforefieldinit'.
			static _ResourceLoadTextureCoroutine_d__3()
			{
				Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_AsyncLoader>.NativeClassPtr, "<ResourceLoadTextureCoroutine>d__3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr);
				SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr, "<>1__state");
				SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr, "<>2__current");
				SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr, "path");
				SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr, "callback");
				SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr__request_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr, "<request>5__2");
				SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr, 100663934);
				SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr, 100663935);
				SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr, 100663936);
				SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr, 100663937);
				SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr, 100663938);
				SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr, 100663939);
			}

			// Token: 0x06000481 RID: 1153 RVA: 0x0001501C File Offset: 0x0001321C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ResourceLoadTextureCoroutine_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000482 RID: 1154 RVA: 0x00015064 File Offset: 0x00013264
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000483 RID: 1155 RVA: 0x00015098 File Offset: 0x00013298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107597, XrefRangeEnd = 107603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000F6 RID: 246
			// (get) Token: 0x06000484 RID: 1156 RVA: 0x000150D4 File Offset: 0x000132D4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000485 RID: 1157 RVA: 0x00015114 File Offset: 0x00013314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107603, XrefRangeEnd = 107608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000F7 RID: 247
			// (get) Token: 0x06000486 RID: 1158 RVA: 0x00015148 File Offset: 0x00013348
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000487 RID: 1159 RVA: 0x00003543 File Offset: 0x00001743
			public _ResourceLoadTextureCoroutine_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000F1 RID: 241
			// (get) Token: 0x06000488 RID: 1160 RVA: 0x00015188 File Offset: 0x00013388
			// (set) Token: 0x06000489 RID: 1161 RVA: 0x0000354C File Offset: 0x0000174C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000F2 RID: 242
			// (get) Token: 0x0600048A RID: 1162 RVA: 0x000151B0 File Offset: 0x000133B0
			// (set) Token: 0x0600048B RID: 1163 RVA: 0x00003567 File Offset: 0x00001767
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F3 RID: 243
			// (get) Token: 0x0600048C RID: 1164 RVA: 0x000151E0 File Offset: 0x000133E0
			// (set) Token: 0x0600048D RID: 1165 RVA: 0x00003586 File Offset: 0x00001786
			public unsafe string path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000F4 RID: 244
			// (get) Token: 0x0600048E RID: 1166 RVA: 0x00015208 File Offset: 0x00013408
			// (set) Token: 0x0600048F RID: 1167 RVA: 0x000035A5 File Offset: 0x000017A5
			public unsafe Action<T> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000F5 RID: 245
			// (get) Token: 0x06000490 RID: 1168 RVA: 0x00015238 File Offset: 0x00013438
			// (set) Token: 0x06000491 RID: 1169 RVA: 0x000035C4 File Offset: 0x000017C4
			public unsafe ResourceRequest _request_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr__request_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_AsyncLoader._ResourceLoadTextureCoroutine_d__3<T>.NativeFieldInfoPtr__request_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400035F RID: 863
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000360 RID: 864
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000361 RID: 865
			private static readonly IntPtr NativeFieldInfoPtr_path;

			// Token: 0x04000362 RID: 866
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04000363 RID: 867
			private static readonly IntPtr NativeFieldInfoPtr__request_5__2;

			// Token: 0x04000364 RID: 868
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000365 RID: 869
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000366 RID: 870
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000367 RID: 871
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000368 RID: 872
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000369 RID: 873
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200005D RID: 93
		private sealed class MethodInfoStoreGeneric_LoadResource_Public_Static_Void_String_Action_1_T_0<T>
		{
			// Token: 0x0400036A RID: 874
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SA_AsyncLoader.NativeMethodInfoPtr_LoadResource_Public_Static_Void_String_Action_1_T_0, Il2CppClassPointerStore<SA_AsyncLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200005E RID: 94
		private sealed class MethodInfoStoreGeneric_ResourceLoadCoroutine_Private_Static_IEnumerator_String_Action_1_T_0<T>
		{
			// Token: 0x0400036B RID: 875
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SA_AsyncLoader.NativeMethodInfoPtr_ResourceLoadCoroutine_Private_Static_IEnumerator_String_Action_1_T_0, Il2CppClassPointerStore<SA_AsyncLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200005F RID: 95
		private sealed class MethodInfoStoreGeneric_LoadTexture_Public_Static_Void_String_Action_1_T_0<T>
		{
			// Token: 0x0400036C RID: 876
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SA_AsyncLoader.NativeMethodInfoPtr_LoadTexture_Public_Static_Void_String_Action_1_T_0, Il2CppClassPointerStore<SA_AsyncLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000060 RID: 96
		private sealed class MethodInfoStoreGeneric_ResourceLoadTextureCoroutine_Private_Static_IEnumerator_String_Action_1_T_0<T>
		{
			// Token: 0x0400036D RID: 877
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SA_AsyncLoader.NativeMethodInfoPtr_ResourceLoadTextureCoroutine_Private_Static_IEnumerator_String_Action_1_T_0, Il2CppClassPointerStore<SA_AsyncLoader>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
