using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x0200001C RID: 28
	public class GUILayoutGroup : GUILayoutEntry
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x00012588 File Offset: 0x00010788
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutGroup()
		{
			Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr);
			GUILayoutGroup.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "entries");
			GUILayoutGroup.NativeFieldInfoPtr_isVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "isVertical");
			GUILayoutGroup.NativeFieldInfoPtr_resetCoords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "resetCoords");
			GUILayoutGroup.NativeFieldInfoPtr_spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "spacing");
			GUILayoutGroup.NativeFieldInfoPtr_sameSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "sameSize");
			GUILayoutGroup.NativeFieldInfoPtr_isWindow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "isWindow");
			GUILayoutGroup.NativeFieldInfoPtr_windowID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "windowID");
			GUILayoutGroup.NativeFieldInfoPtr_m_Cursor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_Cursor");
			GUILayoutGroup.NativeFieldInfoPtr_m_StretchableCountX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_StretchableCountX");
			GUILayoutGroup.NativeFieldInfoPtr_m_StretchableCountY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_StretchableCountY");
			GUILayoutGroup.NativeFieldInfoPtr_m_UserSpecifiedWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_UserSpecifiedWidth");
			GUILayoutGroup.NativeFieldInfoPtr_m_UserSpecifiedHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_UserSpecifiedHeight");
			GUILayoutGroup.NativeFieldInfoPtr_m_ChildMinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_ChildMinWidth");
			GUILayoutGroup.NativeFieldInfoPtr_m_ChildMaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_ChildMaxWidth");
			GUILayoutGroup.NativeFieldInfoPtr_m_ChildMinHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_ChildMinHeight");
			GUILayoutGroup.NativeFieldInfoPtr_m_ChildMaxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_ChildMaxHeight");
			GUILayoutGroup.NativeFieldInfoPtr_m_MarginLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_MarginLeft");
			GUILayoutGroup.NativeFieldInfoPtr_m_MarginRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_MarginRight");
			GUILayoutGroup.NativeFieldInfoPtr_m_MarginTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_MarginTop");
			GUILayoutGroup.NativeFieldInfoPtr_m_MarginBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "m_MarginBottom");
			GUILayoutGroup.NativeFieldInfoPtr_none = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, "none");
			GUILayoutGroup.NativeMethodInfoPtr_get_marginLeft_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663678);
			GUILayoutGroup.NativeMethodInfoPtr_get_marginRight_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663679);
			GUILayoutGroup.NativeMethodInfoPtr_get_marginTop_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663680);
			GUILayoutGroup.NativeMethodInfoPtr_get_marginBottom_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663681);
			GUILayoutGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663682);
			GUILayoutGroup.NativeMethodInfoPtr_ApplyOptions_Public_Virtual_Void_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663683);
			GUILayoutGroup.NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663684);
			GUILayoutGroup.NativeMethodInfoPtr_ResetCursor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663685);
			GUILayoutGroup.NativeMethodInfoPtr_GetNext_Public_GUILayoutEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663686);
			GUILayoutGroup.NativeMethodInfoPtr_Add_Public_Void_GUILayoutEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663687);
			GUILayoutGroup.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663688);
			GUILayoutGroup.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663689);
			GUILayoutGroup.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663690);
			GUILayoutGroup.NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663691);
			GUILayoutGroup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr, 100663692);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00012888 File Offset: 0x00010A88
		public unsafe override int marginLeft
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_get_marginLeft_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x000128D0 File Offset: 0x00010AD0
		public unsafe override int marginRight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_get_marginRight_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00012918 File Offset: 0x00010B18
		public unsafe override int marginTop
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 41028, RefRangeEnd = 41035, XrefRangeStart = 41028, XrefRangeEnd = 41035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_get_marginTop_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00012960 File Offset: 0x00010B60
		public unsafe override int marginBottom
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_get_marginBottom_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000129A8 File Offset: 0x00010BA8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 87911, RefRangeEnd = 87917, XrefRangeStart = 87897, XrefRangeEnd = 87911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUILayoutGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000129E4 File Offset: 0x00010BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87917, XrefRangeEnd = 87924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyOptions(Il2CppReferenceArray<GUILayoutOption> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_ApplyOptions_Public_Virtual_Void_Il2CppReferenceArray_1_GUILayoutOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00012A34 File Offset: 0x00010C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87924, XrefRangeEnd = 87938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyStyleSettings(GUIStyle style)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_Void_GUIStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00012A84 File Offset: 0x00010C84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 87938, RefRangeEnd = 87941, XrefRangeStart = 87938, XrefRangeEnd = 87938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutGroup.NativeMethodInfoPtr_ResetCursor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00012AB8 File Offset: 0x00010CB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 87951, RefRangeEnd = 87955, XrefRangeStart = 87941, XrefRangeEnd = 87951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUILayoutEntry GetNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutGroup.NativeMethodInfoPtr_GetNext_Public_GUILayoutEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUILayoutEntry>(intPtr3) : null;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00012AF8 File Offset: 0x00010CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87955, XrefRangeEnd = 87959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(GUILayoutEntry e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutGroup.NativeMethodInfoPtr_Add_Public_Void_GUILayoutEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00012B3C File Offset: 0x00010D3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88015, RefRangeEnd = 88016, XrefRangeStart = 87959, XrefRangeEnd = 88015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00012B78 File Offset: 0x00010D78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 88081, RefRangeEnd = 88083, XrefRangeStart = 88016, XrefRangeEnd = 88081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetHorizontal(float x, float width)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00012BD0 File Offset: 0x00010DD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88138, RefRangeEnd = 88139, XrefRangeStart = 88083, XrefRangeEnd = 88138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CalcHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00012C0C File Offset: 0x00010E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88182, RefRangeEnd = 88183, XrefRangeStart = 88139, XrefRangeEnd = 88182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetVertical(float y, float height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref y;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00012C64 File Offset: 0x00010E64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88183, XrefRangeEnd = 88237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutGroup.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00003F09 File Offset: 0x00002109
		public GUILayoutGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x00012CA8 File Offset: 0x00010EA8
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x00003F12 File Offset: 0x00002112
		public unsafe List<GUILayoutEntry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GUILayoutEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00012CD8 File Offset: 0x00010ED8
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00003F31 File Offset: 0x00002131
		public unsafe bool isVertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_isVertical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_isVertical)) = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00012D00 File Offset: 0x00010F00
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00003F4C File Offset: 0x0000214C
		public unsafe bool resetCoords
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_resetCoords);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_resetCoords)) = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00012D28 File Offset: 0x00010F28
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00003F67 File Offset: 0x00002167
		public unsafe float spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_spacing)) = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00012D50 File Offset: 0x00010F50
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00003F82 File Offset: 0x00002182
		public unsafe bool sameSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_sameSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_sameSize)) = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00012D78 File Offset: 0x00010F78
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00003F9D File Offset: 0x0000219D
		public unsafe bool isWindow
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_isWindow);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_isWindow)) = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00012DA0 File Offset: 0x00010FA0
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00003FB8 File Offset: 0x000021B8
		public unsafe int windowID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_windowID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_windowID)) = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00012DC8 File Offset: 0x00010FC8
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00003FD3 File Offset: 0x000021D3
		public unsafe int m_Cursor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_Cursor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_Cursor)) = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00012DF0 File Offset: 0x00010FF0
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x00003FEE File Offset: 0x000021EE
		public unsafe int m_StretchableCountX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_StretchableCountX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_StretchableCountX)) = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00012E18 File Offset: 0x00011018
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x00004009 File Offset: 0x00002209
		public unsafe int m_StretchableCountY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_StretchableCountY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_StretchableCountY)) = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00012E40 File Offset: 0x00011040
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00004024 File Offset: 0x00002224
		public unsafe bool m_UserSpecifiedWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_UserSpecifiedWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_UserSpecifiedWidth)) = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00012E68 File Offset: 0x00011068
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x0000403F File Offset: 0x0000223F
		public unsafe bool m_UserSpecifiedHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_UserSpecifiedHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_UserSpecifiedHeight)) = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00012E90 File Offset: 0x00011090
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x0000405A File Offset: 0x0000225A
		public unsafe float m_ChildMinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMinWidth)) = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00012EB8 File Offset: 0x000110B8
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00004075 File Offset: 0x00002275
		public unsafe float m_ChildMaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMaxWidth)) = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00012EE0 File Offset: 0x000110E0
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00004090 File Offset: 0x00002290
		public unsafe float m_ChildMinHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMinHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMinHeight)) = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00012F08 File Offset: 0x00011108
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x000040AB File Offset: 0x000022AB
		public unsafe float m_ChildMaxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMaxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_ChildMaxHeight)) = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00012F30 File Offset: 0x00011130
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x000040C6 File Offset: 0x000022C6
		public unsafe int m_MarginLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginLeft)) = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00012F58 File Offset: 0x00011158
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x000040E1 File Offset: 0x000022E1
		public unsafe int m_MarginRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginRight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginRight)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x00012F80 File Offset: 0x00011180
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x000040FC File Offset: 0x000022FC
		public unsafe int m_MarginTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginTop)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00012FA8 File Offset: 0x000111A8
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00004117 File Offset: 0x00002317
		public unsafe int m_MarginBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginBottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutGroup.NativeFieldInfoPtr_m_MarginBottom)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00012FD0 File Offset: 0x000111D0
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00004132 File Offset: 0x00002332
		public unsafe static GUILayoutEntry none
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutGroup.NativeFieldInfoPtr_none, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUILayoutEntry>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutGroup.NativeFieldInfoPtr_none, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00004144 File Offset: 0x00002344
		public Rect PeekNext()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00004151 File Offset: 0x00002351
		public Rect GetLast()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeFieldInfoPtr_isVertical;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeFieldInfoPtr_resetCoords;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeFieldInfoPtr_spacing;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeFieldInfoPtr_sameSize;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeFieldInfoPtr_isWindow;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeFieldInfoPtr_windowID;

		// Token: 0x04000296 RID: 662
		private static readonly IntPtr NativeFieldInfoPtr_m_Cursor;

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeFieldInfoPtr_m_StretchableCountX;

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_m_StretchableCountY;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_m_UserSpecifiedWidth;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_m_UserSpecifiedHeight;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildMinWidth;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildMaxWidth;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildMinHeight;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildMaxHeight;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr_m_MarginLeft;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr_m_MarginRight;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_m_MarginTop;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_m_MarginBottom;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr_none;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_get_marginLeft_Public_Virtual_get_Int32_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_get_marginRight_Public_Virtual_get_Int32_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_get_marginTop_Public_Virtual_get_Int32_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_get_marginBottom_Public_Virtual_get_Int32_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOptions_Public_Virtual_Void_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_Void_GUIStyle_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_ResetCursor_Public_Void_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_GetNext_Public_GUILayoutEntry_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_GUILayoutEntry_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_CalcWidth_Public_Virtual_Void_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontal_Public_Virtual_Void_Single_Single_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Virtual_Void_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_SetVertical_Public_Virtual_Void_Single_Single_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
