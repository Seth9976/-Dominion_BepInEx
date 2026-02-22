using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200001A RID: 26
	public class GUILayoutEntry : Object
	{
		// Token: 0x0600048A RID: 1162 RVA: 0x00011A3C File Offset: 0x0000FC3C
		// Note: this type is marked as 'beforefieldinit'.
		static GUILayoutEntry()
		{
			Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUILayoutEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr);
			GUILayoutEntry.NativeFieldInfoPtr_minWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "minWidth");
			GUILayoutEntry.NativeFieldInfoPtr_maxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "maxWidth");
			GUILayoutEntry.NativeFieldInfoPtr_minHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "minHeight");
			GUILayoutEntry.NativeFieldInfoPtr_maxHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "maxHeight");
			GUILayoutEntry.NativeFieldInfoPtr_rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "rect");
			GUILayoutEntry.NativeFieldInfoPtr_stretchWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "stretchWidth");
			GUILayoutEntry.NativeFieldInfoPtr_stretchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "stretchHeight");
			GUILayoutEntry.NativeFieldInfoPtr_consideredForMargin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "consideredForMargin");
			GUILayoutEntry.NativeFieldInfoPtr_m_Style = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "m_Style");
			GUILayoutEntry.NativeFieldInfoPtr_kDummyRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "kDummyRect");
			GUILayoutEntry.NativeFieldInfoPtr_indent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, "indent");
			GUILayoutEntry.NativeMethodInfoPtr_get_style_Public_get_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663657);
			GUILayoutEntry.NativeMethodInfoPtr_set_style_Public_set_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663658);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginLeft_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663659);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginRight_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663660);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginTop_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663661);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginBottom_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663662);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginHorizontal_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663663);
			GUILayoutEntry.NativeMethodInfoPtr_get_marginVertical_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663664);
			GUILayoutEntry.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663665);
			GUILayoutEntry.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663666);
			GUILayoutEntry.NativeMethodInfoPtr_CalcWidth_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663667);
			GUILayoutEntry.NativeMethodInfoPtr_CalcHeight_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663668);
			GUILayoutEntry.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663669);
			GUILayoutEntry.NativeMethodInfoPtr_SetVertical_Public_Virtual_New_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663670);
			GUILayoutEntry.NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_New_Void_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663671);
			GUILayoutEntry.NativeMethodInfoPtr_ApplyOptions_Public_Virtual_New_Void_Il2CppReferenceArray_1_GUILayoutOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663672);
			GUILayoutEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr, 100663673);
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00011C9C File Offset: 0x0000FE9C
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00011CDC File Offset: 0x0000FEDC
		public unsafe GUIStyle style
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr_get_style_Public_get_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr_set_style_Public_set_Void_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00011D20 File Offset: 0x0000FF20
		public unsafe virtual int marginLeft
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87645, XrefRangeEnd = 87648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_get_marginLeft_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00011D68 File Offset: 0x0000FF68
		public unsafe virtual int marginRight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87648, XrefRangeEnd = 87651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_get_marginRight_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00011DB0 File Offset: 0x0000FFB0
		public unsafe virtual int marginTop
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87651, XrefRangeEnd = 87654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_get_marginTop_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00011DF8 File Offset: 0x0000FFF8
		public unsafe virtual int marginBottom
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87654, XrefRangeEnd = 87657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_get_marginBottom_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00011E40 File Offset: 0x00010040
		public unsafe int marginHorizontal
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 87657, RefRangeEnd = 87661, XrefRangeStart = 87657, XrefRangeEnd = 87657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr_get_marginHorizontal_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00011E7C File Offset: 0x0001007C
		public unsafe int marginVertical
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 87661, RefRangeEnd = 87663, XrefRangeStart = 87661, XrefRangeEnd = 87661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr_get_marginVertical_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00011EB8 File Offset: 0x000100B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 87672, RefRangeEnd = 87675, XrefRangeStart = 87663, XrefRangeEnd = 87672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _minWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _minHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_style);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00011F3C File Offset: 0x0001013C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 87681, RefRangeEnd = 87683, XrefRangeStart = 87675, XrefRangeEnd = 87681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GUILayoutEntry(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, Il2CppReferenceArray<GUILayoutOption> options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GUILayoutEntry>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref _minWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _minHeight;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _maxHeight;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_style);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUILayoutEntry.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00011FD4 File Offset: 0x000101D4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalcWidth()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_CalcWidth_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00012010 File Offset: 0x00010210
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CalcHeight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_CalcHeight_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0001204C File Offset: 0x0001024C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87683, XrefRangeEnd = 87685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetHorizontal(float x, float width)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_SetHorizontal_Public_Virtual_New_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000120A4 File Offset: 0x000102A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87685, XrefRangeEnd = 87687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVertical(float y, float height)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_SetVertical_Public_Virtual_New_Void_Single_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x000120FC File Offset: 0x000102FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87687, XrefRangeEnd = 87696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyStyleSettings(GUIStyle style)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(style);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_New_Void_GUIStyle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0001214C File Offset: 0x0001034C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87722, RefRangeEnd = 87723, XrefRangeStart = 87696, XrefRangeEnd = 87722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyOptions(Il2CppReferenceArray<GUILayoutOption> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_ApplyOptions_Public_Virtual_New_Void_Il2CppReferenceArray_1_GUILayoutOption_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0001219C File Offset: 0x0001039C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 87878, RefRangeEnd = 87879, XrefRangeStart = 87723, XrefRangeEnd = 87878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GUILayoutEntry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00003D8F File Offset: 0x00001F8F
		public GUILayoutEntry(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000121E0 File Offset: 0x000103E0
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00003D98 File Offset: 0x00001F98
		public unsafe float minWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_minWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_minWidth)) = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00012208 File Offset: 0x00010408
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00003DB3 File Offset: 0x00001FB3
		public unsafe float maxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_maxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_maxWidth)) = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00012230 File Offset: 0x00010430
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00003DCE File Offset: 0x00001FCE
		public unsafe float minHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_minHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_minHeight)) = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00012258 File Offset: 0x00010458
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00003DE9 File Offset: 0x00001FE9
		public unsafe float maxHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_maxHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_maxHeight)) = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00012280 File Offset: 0x00010480
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00003E04 File Offset: 0x00002004
		public unsafe Rect rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_rect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_rect)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x000122A8 File Offset: 0x000104A8
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00003E1F File Offset: 0x0000201F
		public unsafe int stretchWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_stretchWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_stretchWidth)) = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x000122D0 File Offset: 0x000104D0
		// (set) Token: 0x060004AA RID: 1194 RVA: 0x00003E3A File Offset: 0x0000203A
		public unsafe int stretchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_stretchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_stretchHeight)) = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x000122F8 File Offset: 0x000104F8
		// (set) Token: 0x060004AC RID: 1196 RVA: 0x00003E55 File Offset: 0x00002055
		public unsafe bool consideredForMargin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_consideredForMargin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_consideredForMargin)) = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00012320 File Offset: 0x00010520
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00003E70 File Offset: 0x00002070
		public unsafe GUIStyle m_Style
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_m_Style);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GUIStyle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GUILayoutEntry.NativeFieldInfoPtr_m_Style), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00012350 File Offset: 0x00010550
		// (set) Token: 0x060004B0 RID: 1200 RVA: 0x00003E8F File Offset: 0x0000208F
		public unsafe static Rect kDummyRect
		{
			get
			{
				Rect rect;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutEntry.NativeFieldInfoPtr_kDummyRect, (void*)(&rect));
				return rect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutEntry.NativeFieldInfoPtr_kDummyRect, (void*)(&value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x0001236C File Offset: 0x0001056C
		// (set) Token: 0x060004B2 RID: 1202 RVA: 0x00003E9D File Offset: 0x0000209D
		public unsafe static int indent
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GUILayoutEntry.NativeFieldInfoPtr_indent, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUILayoutEntry.NativeFieldInfoPtr_indent, (void*)(&value));
			}
		}

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeFieldInfoPtr_minWidth;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeFieldInfoPtr_maxWidth;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeFieldInfoPtr_minHeight;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeFieldInfoPtr_maxHeight;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeFieldInfoPtr_rect;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeFieldInfoPtr_stretchWidth;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeFieldInfoPtr_stretchHeight;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeFieldInfoPtr_consideredForMargin;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeFieldInfoPtr_m_Style;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeFieldInfoPtr_kDummyRect;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_indent;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_get_style_Public_get_GUIStyle_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_set_style_Public_set_Void_GUIStyle_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_get_marginLeft_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_get_marginRight_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_get_marginTop_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_get_marginBottom_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_get_marginHorizontal_Public_get_Int32_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_get_marginVertical_Public_get_Int32_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_GUIStyle_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_CalcWidth_Public_Virtual_New_Void_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_CalcHeight_Public_Virtual_New_Void_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_SetHorizontal_Public_Virtual_New_Void_Single_Single_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_SetVertical_Public_Virtual_New_Void_Single_Single_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyleSettings_Protected_Virtual_New_Void_GUIStyle_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_ApplyOptions_Public_Virtual_New_Void_Il2CppReferenceArray_1_GUILayoutOption_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
