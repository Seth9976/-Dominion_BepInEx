using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000014 RID: 20
	[Serializable]
	public sealed class GUIStyleState : Object
	{
		// Token: 0x06000357 RID: 855 RVA: 0x0000DFEC File Offset: 0x0000C1EC
		// Note: this type is marked as 'beforefieldinit'.
		static GUIStyleState()
		{
			Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIStyleState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr);
			GUIStyleState.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, "m_Ptr");
			GUIStyleState.NativeFieldInfoPtr_m_SourceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, "m_SourceStyle");
			GUIStyleState.NativeMethodInfoPtr_set_textColor_Public_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663551);
			GUIStyleState.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663552);
			GUIStyleState.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663553);
			GUIStyleState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663554);
			GUIStyleState.NativeMethodInfoPtr__ctor_Private_Void_GUIStyle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663555);
			GUIStyleState.NativeMethodInfoPtr_GetGUIStyleState_Internal_Static_GUIStyleState_GUIStyle_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663556);
			GUIStyleState.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663557);
			GUIStyleState.NativeMethodInfoPtr_set_textColor_Injected_Private_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr, 100663558);
			GUIStyleState.get_backgroundDelegateField = IL2CPP.ResolveICall<GUIStyleState.get_backgroundDelegate>("UnityEngine.GUIStyleState::get_background");
			GUIStyleState.set_backgroundDelegateField = IL2CPP.ResolveICall<GUIStyleState.set_backgroundDelegate>("UnityEngine.GUIStyleState::set_background");
			GUIStyleState.get_textColor_InjectedDelegateField = IL2CPP.ResolveICall<GUIStyleState.get_textColor_InjectedDelegate>("UnityEngine.GUIStyleState::get_textColor_Injected");
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0000E39C File Offset: 0x0000C59C
		// (set) Token: 0x06000358 RID: 856 RVA: 0x0000E114 File Offset: 0x0000C314
		public unsafe Color textColor
		{
			get
			{
				Color color;
				this.get_textColor_Injected(out color);
				return color;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87065, XrefRangeEnd = 87067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_set_textColor_Public_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000E154 File Offset: 0x0000C354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87067, XrefRangeEnd = 87069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_Init_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000E184 File Offset: 0x0000C384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87069, XrefRangeEnd = 87071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000E1B8 File Offset: 0x0000C3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87071, XrefRangeEnd = 87074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyleState()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000E1F4 File Offset: 0x0000C3F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62337, RefRangeEnd = 62339, XrefRangeStart = 62337, XrefRangeEnd = 62339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUIStyleState(GUIStyle sourceStyle, IntPtr source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUIStyleState>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceStyle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr__ctor_Private_Void_GUIStyle_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000E250 File Offset: 0x0000C450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87074, XrefRangeEnd = 87078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GUIStyleState GetGUIStyleState(GUIStyle sourceStyle, IntPtr source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceStyle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_GetGUIStyleState_Internal_Static_GUIStyleState_GUIStyle_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyleState>(intPtr3) : null;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87078, XrefRangeEnd = 87084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000E2D8 File Offset: 0x0000C4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87084, XrefRangeEnd = 87086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void set_textColor_Injected(ref Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStyleState.NativeMethodInfoPtr_set_textColor_Injected_Private_Void_byref_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00003561 File Offset: 0x00001761
		public GUIStyleState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0000E318 File Offset: 0x0000C518
		// (set) Token: 0x06000362 RID: 866 RVA: 0x0000356A File Offset: 0x0000176A
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyleState.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyleState.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0000E340 File Offset: 0x0000C540
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00003585 File Offset: 0x00001785
		public unsafe GUIStyle m_SourceStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyleState.NativeFieldInfoPtr_m_SourceStyle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUIStyleState.NativeFieldInfoPtr_m_SourceStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0000E370 File Offset: 0x0000C570
		// (set) Token: 0x06000366 RID: 870 RVA: 0x000035A4 File Offset: 0x000017A4
		public Texture2D background
		{
			get
			{
				IntPtr intPtr = GUIStyleState.get_backgroundDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				GUIStyleState.set_backgroundDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
		public static GUIStyleState ProduceGUIStyleStateFromDeserialization(GUIStyle sourceStyle, IntPtr source)
		{
			return new GUIStyleState(sourceStyle, source);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000035BC File Offset: 0x000017BC
		public void get_textColor_Injected(out Color ret)
		{
			GUIStyleState.get_textColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceStyle;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_set_textColor_Public_set_Void_Color_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_IntPtr_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_GUIStyle_IntPtr_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_GetGUIStyleState_Internal_Static_GUIStyleState_GUIStyle_IntPtr_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_set_textColor_Injected_Private_Void_byref_Color_0;

		// Token: 0x040001B2 RID: 434
		private static readonly GUIStyleState.get_backgroundDelegate get_backgroundDelegateField;

		// Token: 0x040001B3 RID: 435
		private static readonly GUIStyleState.set_backgroundDelegate set_backgroundDelegateField;

		// Token: 0x040001B4 RID: 436
		private static readonly GUIStyleState.get_textColor_InjectedDelegate get_textColor_InjectedDelegateField;

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x060006A7 RID: 1703
		private delegate IntPtr get_backgroundDelegate(IntPtr @this);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x060006A9 RID: 1705
		private delegate void set_backgroundDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x060006AB RID: 1707
		private delegate void get_textColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
