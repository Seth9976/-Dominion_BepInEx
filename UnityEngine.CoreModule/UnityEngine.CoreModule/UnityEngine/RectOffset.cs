using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000046 RID: 70
	[Serializable]
	public class RectOffset : Object
	{
		// Token: 0x0600048C RID: 1164 RVA: 0x00021678 File Offset: 0x0001F878
		// Note: this type is marked as 'beforefieldinit'.
		static RectOffset()
		{
			Il2CppClassPointerStore<RectOffset>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RectOffset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectOffset>.NativeClassPtr);
			RectOffset.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, "m_Ptr");
			RectOffset.NativeFieldInfoPtr_m_SourceStyle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, "m_SourceStyle");
			RectOffset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663558);
			RectOffset.NativeMethodInfoPtr__ctor_Internal_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663559);
			RectOffset.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663560);
			RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663561);
			RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663562);
			RectOffset.NativeMethodInfoPtr_Destroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663563);
			RectOffset.NativeMethodInfoPtr_InternalCreate_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663564);
			RectOffset.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663565);
			RectOffset.NativeMethodInfoPtr_get_left_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663566);
			RectOffset.NativeMethodInfoPtr_get_right_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663567);
			RectOffset.NativeMethodInfoPtr_get_top_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663568);
			RectOffset.NativeMethodInfoPtr_get_bottom_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663569);
			RectOffset.NativeMethodInfoPtr_get_horizontal_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663570);
			RectOffset.NativeMethodInfoPtr_get_vertical_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663571);
			RectOffset.NativeMethodInfoPtr_Remove_Public_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663572);
			RectOffset.NativeMethodInfoPtr_Remove_Injected_Private_Void_byref_Rect_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectOffset>.NativeClassPtr, 100663573);
			RectOffset.set_leftDelegateField = IL2CPP.ResolveICall<RectOffset.set_leftDelegate>("UnityEngine.RectOffset::set_left");
			RectOffset.set_rightDelegateField = IL2CPP.ResolveICall<RectOffset.set_rightDelegate>("UnityEngine.RectOffset::set_right");
			RectOffset.set_topDelegateField = IL2CPP.ResolveICall<RectOffset.set_topDelegate>("UnityEngine.RectOffset::set_top");
			RectOffset.set_bottomDelegateField = IL2CPP.ResolveICall<RectOffset.set_bottomDelegate>("UnityEngine.RectOffset::set_bottom");
			RectOffset.Add_InjectedDelegateField = IL2CPP.ResolveICall<RectOffset.Add_InjectedDelegate>("UnityEngine.RectOffset::Add_Injected");
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0002185C File Offset: 0x0001FA5C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 62330, RefRangeEnd = 62336, XrefRangeStart = 62327, XrefRangeEnd = 62330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectOffset()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectOffset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00021898 File Offset: 0x0001FA98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62337, RefRangeEnd = 62339, XrefRangeStart = 62336, XrefRangeEnd = 62337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectOffset(Object sourceStyle, IntPtr source)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RectOffset>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceStyle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref source;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr__ctor_Internal_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000218F4 File Offset: 0x0001FAF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62339, XrefRangeEnd = 62346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectOffset.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00021930 File Offset: 0x0001FB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62346, XrefRangeEnd = 62347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00021974 File Offset: 0x0001FB74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62373, RefRangeEnd = 62374, XrefRangeStart = 62347, XrefRangeEnd = 62373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(string format, IFormatProvider formatProvider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000219D0 File Offset: 0x0001FBD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62374, XrefRangeEnd = 62378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_Destroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00021A04 File Offset: 0x0001FC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62378, XrefRangeEnd = 62380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr InternalCreate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_InternalCreate_Private_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00021A34 File Offset: 0x0001FC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62380, XrefRangeEnd = 62382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalDestroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00021A68 File Offset: 0x0001FC68
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00004B40 File Offset: 0x00002D40
		public unsafe int left
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 62384, RefRangeEnd = 62395, XrefRangeStart = 62382, XrefRangeEnd = 62384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_left_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RectOffset.set_leftDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00021AA4 File Offset: 0x0001FCA4
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00004B53 File Offset: 0x00002D53
		public unsafe int right
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 62397, RefRangeEnd = 62402, XrefRangeStart = 62395, XrefRangeEnd = 62397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_right_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RectOffset.set_rightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00021AE0 File Offset: 0x0001FCE0
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00004B66 File Offset: 0x00002D66
		public unsafe int top
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 62404, RefRangeEnd = 62416, XrefRangeStart = 62402, XrefRangeEnd = 62404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_top_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RectOffset.set_topDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00021B1C File Offset: 0x0001FD1C
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00004B79 File Offset: 0x00002D79
		public unsafe int bottom
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 62418, RefRangeEnd = 62422, XrefRangeStart = 62416, XrefRangeEnd = 62418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_bottom_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				RectOffset.set_bottomDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00021B58 File Offset: 0x0001FD58
		public unsafe int horizontal
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 62424, RefRangeEnd = 62433, XrefRangeStart = 62422, XrefRangeEnd = 62424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_horizontal_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00021B94 File Offset: 0x0001FD94
		public unsafe int vertical
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 62435, RefRangeEnd = 62444, XrefRangeStart = 62433, XrefRangeEnd = 62435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_get_vertical_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00021BD0 File Offset: 0x0001FDD0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 62446, RefRangeEnd = 62450, XrefRangeStart = 62444, XrefRangeEnd = 62446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect Remove(Rect rect)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_Remove_Public_Rect_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00021C1C File Offset: 0x0001FE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62450, XrefRangeEnd = 62452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove_Injected(ref Rect rect, out Rect ret)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &rect;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectOffset.NativeMethodInfoPtr_Remove_Injected_Private_Void_byref_Rect_byref_Rect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00004AFD File Offset: 0x00002CFD
		public RectOffset(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00021C68 File Offset: 0x0001FE68
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x00004B06 File Offset: 0x00002D06
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00021C90 File Offset: 0x0001FE90
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x00004B21 File Offset: 0x00002D21
		public unsafe Object m_SourceStyle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_SourceStyle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RectOffset.NativeFieldInfoPtr_m_SourceStyle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00021CC0 File Offset: 0x0001FEC0
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00021CDC File Offset: 0x0001FEDC
		public Rect Add(Rect rect)
		{
			Rect rect2;
			this.Add_Injected(ref rect, out rect2);
			return rect2;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00004B8C File Offset: 0x00002D8C
		public void Add_Injected(ref Rect rect, out Rect ret)
		{
			RectOffset.Add_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref rect, out ret);
		}

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceStyle;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_IntPtr_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Private_Void_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_InternalCreate_Private_Static_IntPtr_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_InternalDestroy_Private_Static_Void_IntPtr_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_get_left_Public_get_Int32_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_get_right_Public_get_Int32_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_get_top_Public_get_Int32_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_get_bottom_Public_get_Int32_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontal_Public_get_Int32_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_get_vertical_Public_get_Int32_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Rect_Rect_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Injected_Private_Void_byref_Rect_byref_Rect_0;

		// Token: 0x04000334 RID: 820
		private static readonly RectOffset.set_leftDelegate set_leftDelegateField;

		// Token: 0x04000335 RID: 821
		private static readonly RectOffset.set_rightDelegate set_rightDelegateField;

		// Token: 0x04000336 RID: 822
		private static readonly RectOffset.set_topDelegate set_topDelegateField;

		// Token: 0x04000337 RID: 823
		private static readonly RectOffset.set_bottomDelegate set_bottomDelegateField;

		// Token: 0x04000338 RID: 824
		private static readonly RectOffset.Add_InjectedDelegate Add_InjectedDelegateField;

		// Token: 0x02000439 RID: 1081
		// (Invoke) Token: 0x06002637 RID: 9783
		private delegate void set_leftDelegate(IntPtr @this, int value);

		// Token: 0x0200043A RID: 1082
		// (Invoke) Token: 0x06002639 RID: 9785
		private delegate void set_rightDelegate(IntPtr @this, int value);

		// Token: 0x0200043B RID: 1083
		// (Invoke) Token: 0x0600263B RID: 9787
		private delegate void set_topDelegate(IntPtr @this, int value);

		// Token: 0x0200043C RID: 1084
		// (Invoke) Token: 0x0600263D RID: 9789
		private delegate void set_bottomDelegate(IntPtr @this, int value);

		// Token: 0x0200043D RID: 1085
		// (Invoke) Token: 0x0600263F RID: 9791
		private delegate void Add_InjectedDelegate(IntPtr @this, IntPtr rect, [Out] IntPtr ret);
	}
}
