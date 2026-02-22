using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace SA.Common.Models
{
	// Token: 0x0200031A RID: 794
	public class WWWTextureLoader : MonoBehaviour
	{
		// Token: 0x06002D9A RID: 11674 RVA: 0x000C256C File Offset: 0x000C076C
		// Note: this type is marked as 'beforefieldinit'.
		static WWWTextureLoader()
		{
			Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "SA.Common.Models", "WWWTextureLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr);
			WWWTextureLoader.NativeFieldInfoPtr_LocalCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr, "LocalCache");
			WWWTextureLoader.NativeFieldInfoPtr__url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr, "_url");
			WWWTextureLoader.NativeFieldInfoPtr_OnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr, "OnLoad");
			WWWTextureLoader.NativeMethodInfoPtr_add_OnLoad_Public_add_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr, 100669253);
			WWWTextureLoader.NativeMethodInfoPtr_remove_OnLoad_Public_rem_Void_Action_1_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr, 100669254);
			WWWTextureLoader.NativeMethodInfoPtr_Create_Public_Static_WWWTextureLoader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr, 100669255);
			WWWTextureLoader.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr, 100669256);
			WWWTextureLoader.NativeMethodInfoPtr_LoadTexture_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr, 100669257);
			WWWTextureLoader.NativeMethodInfoPtr_LoadCoroutin_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr, 100669258);
			WWWTextureLoader.NativeMethodInfoPtr_UpdateLocalCache_Private_Static_Void_String_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr, 100669259);
			WWWTextureLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr, 100669260);
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x000C2678 File Offset: 0x000C0878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212709, RefRangeEnd = 212710, XrefRangeStart = 212705, XrefRangeEnd = 212709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnLoad(Action<Texture2D> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader.NativeMethodInfoPtr_add_OnLoad_Public_add_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x000C26BC File Offset: 0x000C08BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212710, XrefRangeEnd = 212714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnLoad(Action<Texture2D> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader.NativeMethodInfoPtr_remove_OnLoad_Public_rem_Void_Action_1_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x000C2700 File Offset: 0x000C0900
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212724, RefRangeEnd = 212725, XrefRangeStart = 212714, XrefRangeEnd = 212724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static WWWTextureLoader Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader.NativeMethodInfoPtr_Create_Public_Static_WWWTextureLoader_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WWWTextureLoader>(intPtr3) : null;
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x000C2734 File Offset: 0x000C0934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212725, XrefRangeEnd = 212730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x000C2768 File Offset: 0x000C0968
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212757, RefRangeEnd = 212758, XrefRangeStart = 212730, XrefRangeEnd = 212757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadTexture(string url)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader.NativeMethodInfoPtr_LoadTexture_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x000C27AC File Offset: 0x000C09AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212758, XrefRangeEnd = 212762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator LoadCoroutin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader.NativeMethodInfoPtr_LoadCoroutin_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x000C27EC File Offset: 0x000C09EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212762, XrefRangeEnd = 212775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateLocalCache(string url, Texture2D image)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(image);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader.NativeMethodInfoPtr_UpdateLocalCache_Private_Static_Void_String_Texture2D_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x000C2834 File Offset: 0x000C0A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212775, XrefRangeEnd = 212792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WWWTextureLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x00011AD7 File Offset: 0x0000FCD7
		public WWWTextureLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06002DA4 RID: 11684 RVA: 0x000C2870 File Offset: 0x000C0A70
		// (set) Token: 0x06002DA5 RID: 11685 RVA: 0x00011AE0 File Offset: 0x0000FCE0
		public unsafe static Dictionary<string, Texture2D> LocalCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WWWTextureLoader.NativeFieldInfoPtr_LocalCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Texture2D>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WWWTextureLoader.NativeFieldInfoPtr_LocalCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06002DA6 RID: 11686 RVA: 0x000C2898 File Offset: 0x000C0A98
		// (set) Token: 0x06002DA7 RID: 11687 RVA: 0x00011AF2 File Offset: 0x0000FCF2
		public unsafe string _url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWTextureLoader.NativeFieldInfoPtr__url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWTextureLoader.NativeFieldInfoPtr__url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x000C28C0 File Offset: 0x000C0AC0
		// (set) Token: 0x06002DA9 RID: 11689 RVA: 0x00011B11 File Offset: 0x0000FD11
		public unsafe Action<Texture2D> OnLoad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWTextureLoader.NativeFieldInfoPtr_OnLoad);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWTextureLoader.NativeFieldInfoPtr_OnLoad), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B7C RID: 11132
		private static readonly IntPtr NativeFieldInfoPtr_LocalCache;

		// Token: 0x04002B7D RID: 11133
		private static readonly IntPtr NativeFieldInfoPtr__url;

		// Token: 0x04002B7E RID: 11134
		private static readonly IntPtr NativeFieldInfoPtr_OnLoad;

		// Token: 0x04002B7F RID: 11135
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLoad_Public_add_Void_Action_1_Texture2D_0;

		// Token: 0x04002B80 RID: 11136
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLoad_Public_rem_Void_Action_1_Texture2D_0;

		// Token: 0x04002B81 RID: 11137
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_WWWTextureLoader_0;

		// Token: 0x04002B82 RID: 11138
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002B83 RID: 11139
		private static readonly IntPtr NativeMethodInfoPtr_LoadTexture_Public_Void_String_0;

		// Token: 0x04002B84 RID: 11140
		private static readonly IntPtr NativeMethodInfoPtr_LoadCoroutin_Private_IEnumerator_0;

		// Token: 0x04002B85 RID: 11141
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLocalCache_Private_Static_Void_String_Texture2D_0;

		// Token: 0x04002B86 RID: 11142
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003D1 RID: 977
		[ObfuscatedName("SA.Common.Models.WWWTextureLoader+<LoadCoroutin>d__8")]
		public sealed class _LoadCoroutin_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x0600389E RID: 14494 RVA: 0x000E6534 File Offset: 0x000E4734
			// Note: this type is marked as 'beforefieldinit'.
			static _LoadCoroutin_d__8()
			{
				Il2CppClassPointerStore<WWWTextureLoader._LoadCoroutin_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr, "<LoadCoroutin>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WWWTextureLoader._LoadCoroutin_d__8>.NativeClassPtr);
				WWWTextureLoader._LoadCoroutin_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTextureLoader._LoadCoroutin_d__8>.NativeClassPtr, "<>1__state");
				WWWTextureLoader._LoadCoroutin_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTextureLoader._LoadCoroutin_d__8>.NativeClassPtr, "<>2__current");
				WWWTextureLoader._LoadCoroutin_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTextureLoader._LoadCoroutin_d__8>.NativeClassPtr, "<>4__this");
				WWWTextureLoader._LoadCoroutin_d__8.NativeFieldInfoPtr__www_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTextureLoader._LoadCoroutin_d__8>.NativeClassPtr, "<www>5__2");
				WWWTextureLoader._LoadCoroutin_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader._LoadCoroutin_d__8>.NativeClassPtr, 100670457);
				WWWTextureLoader._LoadCoroutin_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader._LoadCoroutin_d__8>.NativeClassPtr, 100670458);
				WWWTextureLoader._LoadCoroutin_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader._LoadCoroutin_d__8>.NativeClassPtr, 100670459);
				WWWTextureLoader._LoadCoroutin_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader._LoadCoroutin_d__8>.NativeClassPtr, 100670460);
				WWWTextureLoader._LoadCoroutin_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader._LoadCoroutin_d__8>.NativeClassPtr, 100670461);
				WWWTextureLoader._LoadCoroutin_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader._LoadCoroutin_d__8>.NativeClassPtr, 100670462);
			}

			// Token: 0x0600389F RID: 14495 RVA: 0x000E6628 File Offset: 0x000E4828
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _LoadCoroutin_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WWWTextureLoader._LoadCoroutin_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader._LoadCoroutin_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038A0 RID: 14496 RVA: 0x000E6670 File Offset: 0x000E4870
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader._LoadCoroutin_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038A1 RID: 14497 RVA: 0x000E66A4 File Offset: 0x000E48A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212666, XrefRangeEnd = 212700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader._LoadCoroutin_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D66 RID: 3430
			// (get) Token: 0x060038A2 RID: 14498 RVA: 0x000E66E0 File Offset: 0x000E48E0
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader._LoadCoroutin_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060038A3 RID: 14499 RVA: 0x000E6720 File Offset: 0x000E4920
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212700, XrefRangeEnd = 212705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader._LoadCoroutin_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D67 RID: 3431
			// (get) Token: 0x060038A4 RID: 14500 RVA: 0x000E6754 File Offset: 0x000E4954
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader._LoadCoroutin_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060038A5 RID: 14501 RVA: 0x00015EDF File Offset: 0x000140DF
			public _LoadCoroutin_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D62 RID: 3426
			// (get) Token: 0x060038A6 RID: 14502 RVA: 0x000E6794 File Offset: 0x000E4994
			// (set) Token: 0x060038A7 RID: 14503 RVA: 0x00015EE8 File Offset: 0x000140E8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWTextureLoader._LoadCoroutin_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWTextureLoader._LoadCoroutin_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D63 RID: 3427
			// (get) Token: 0x060038A8 RID: 14504 RVA: 0x000E67BC File Offset: 0x000E49BC
			// (set) Token: 0x060038A9 RID: 14505 RVA: 0x00015F03 File Offset: 0x00014103
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWTextureLoader._LoadCoroutin_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWTextureLoader._LoadCoroutin_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D64 RID: 3428
			// (get) Token: 0x060038AA RID: 14506 RVA: 0x000E67EC File Offset: 0x000E49EC
			// (set) Token: 0x060038AB RID: 14507 RVA: 0x00015F22 File Offset: 0x00014122
			public unsafe WWWTextureLoader __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWTextureLoader._LoadCoroutin_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWWTextureLoader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWTextureLoader._LoadCoroutin_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D65 RID: 3429
			// (get) Token: 0x060038AC RID: 14508 RVA: 0x000E681C File Offset: 0x000E4A1C
			// (set) Token: 0x060038AD RID: 14509 RVA: 0x00015F41 File Offset: 0x00014141
			public unsafe WWW _www_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWTextureLoader._LoadCoroutin_d__8.NativeFieldInfoPtr__www_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWW>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WWWTextureLoader._LoadCoroutin_d__8.NativeFieldInfoPtr__www_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400330B RID: 13067
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400330C RID: 13068
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400330D RID: 13069
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400330E RID: 13070
			private static readonly IntPtr NativeFieldInfoPtr__www_5__2;

			// Token: 0x0400330F RID: 13071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04003310 RID: 13072
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003311 RID: 13073
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04003312 RID: 13074
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04003313 RID: 13075
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04003314 RID: 13076
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003D2 RID: 978
		[ObfuscatedName("SA.Common.Models.WWWTextureLoader+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x060038AE RID: 14510 RVA: 0x000E684C File Offset: 0x000E4A4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WWWTextureLoader.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WWWTextureLoader>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WWWTextureLoader.__c>.NativeClassPtr);
				WWWTextureLoader.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTextureLoader.__c>.NativeClassPtr, "<>9");
				WWWTextureLoader.__c.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WWWTextureLoader.__c>.NativeClassPtr, "<>9__10_0");
				WWWTextureLoader.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader.__c>.NativeClassPtr, 100670464);
				WWWTextureLoader.__c.NativeMethodInfoPtr___ctor_b__10_0_Internal_Void_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WWWTextureLoader.__c>.NativeClassPtr, 100670465);
			}

			// Token: 0x060038AF RID: 14511 RVA: 0x000E68C8 File Offset: 0x000E4AC8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WWWTextureLoader.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060038B0 RID: 14512 RVA: 0x000E6904 File Offset: 0x000E4B04
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__10_0(Texture2D <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WWWTextureLoader.__c.NativeMethodInfoPtr___ctor_b__10_0_Internal_Void_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060038B1 RID: 14513 RVA: 0x00015F60 File Offset: 0x00014160
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D68 RID: 3432
			// (get) Token: 0x060038B2 RID: 14514 RVA: 0x000E6948 File Offset: 0x000E4B48
			// (set) Token: 0x060038B3 RID: 14515 RVA: 0x00015F69 File Offset: 0x00014169
			public unsafe static WWWTextureLoader.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WWWTextureLoader.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWWTextureLoader.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WWWTextureLoader.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D69 RID: 3433
			// (get) Token: 0x060038B4 RID: 14516 RVA: 0x000E6970 File Offset: 0x000E4B70
			// (set) Token: 0x060038B5 RID: 14517 RVA: 0x00015F7B File Offset: 0x0001417B
			public unsafe static Action<Texture2D> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WWWTextureLoader.__c.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Texture2D>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WWWTextureLoader.__c.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003315 RID: 13077
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04003316 RID: 13078
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04003317 RID: 13079
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003318 RID: 13080
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_0_Internal_Void_Texture2D_0;
		}
	}
}
