using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004BE RID: 1214
	[Serializable]
	public class StackTrace : Object
	{
		// Token: 0x06004778 RID: 18296 RVA: 0x00148534 File Offset: 0x00146734
		// Note: this type is marked as 'beforefieldinit'.
		static StackTrace()
		{
			Il2CppClassPointerStore<StackTrace>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "StackTrace");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackTrace>.NativeClassPtr);
			StackTrace.NativeFieldInfoPtr_METHODS_TO_SKIP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "METHODS_TO_SKIP");
			StackTrace.NativeFieldInfoPtr_frames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "frames");
			StackTrace.NativeFieldInfoPtr_captured_traces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "captured_traces");
			StackTrace.NativeFieldInfoPtr_debug_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "debug_info");
			StackTrace.NativeFieldInfoPtr_isAotidSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "isAotidSet");
			StackTrace.NativeFieldInfoPtr_aotid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, "aotid");
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673892);
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673893);
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673894);
			StackTrace.NativeMethodInfoPtr_init_frames_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673895);
			StackTrace.NativeMethodInfoPtr_get_trace_Private_Static_Il2CppReferenceArray_1_StackFrame_Exception_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673896);
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673897);
			StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Exception_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673898);
			StackTrace.NativeMethodInfoPtr_get_FrameCount_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673899);
			StackTrace.NativeMethodInfoPtr_GetFrame_Public_Virtual_New_StackFrame_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673900);
			StackTrace.NativeMethodInfoPtr_GetAotId_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673901);
			StackTrace.NativeMethodInfoPtr_AddFrames_Private_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673902);
			StackTrace.NativeMethodInfoPtr_GetFullNameForStackTrace_Internal_Void_StringBuilder_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673903);
			StackTrace.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673904);
			StackTrace.NativeMethodInfoPtr_ToString_Internal_String_TraceFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackTrace>.NativeClassPtr, 100673905);
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x001486F4 File Offset: 0x001468F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365754, XrefRangeEnd = 365756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x00148730 File Offset: 0x00146930
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365758, RefRangeEnd = 365760, XrefRangeStart = 365756, XrefRangeEnd = 365758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace(bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fNeedFileInfo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600477B RID: 18299 RVA: 0x00148778 File Offset: 0x00146978
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 365762, RefRangeEnd = 365765, XrefRangeStart = 365760, XrefRangeEnd = 365762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace(int skipFrames, bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipFrames;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600477C RID: 18300 RVA: 0x001487D0 File Offset: 0x001469D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 365785, RefRangeEnd = 365788, XrefRangeStart = 365765, XrefRangeEnd = 365785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void init_frames(int skipFrames, bool fNeedFileInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipFrames;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_init_frames_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x0014881C File Offset: 0x00146A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365788, XrefRangeEnd = 365789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<StackFrame> get_trace(Exception e, int skipFrames, bool fNeedFileInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipFrames;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_get_trace_Private_Static_Il2CppReferenceArray_1_StackFrame_Exception_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StackFrame>>(intPtr3) : null;
		}

		// Token: 0x0600477E RID: 18302 RVA: 0x0014887C File Offset: 0x00146A7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365791, RefRangeEnd = 365793, XrefRangeStart = 365789, XrefRangeEnd = 365791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace(Exception e, bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Exception_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600477F RID: 18303 RVA: 0x001488D8 File Offset: 0x00146AD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365795, RefRangeEnd = 365797, XrefRangeStart = 365793, XrefRangeEnd = 365795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackTrace(Exception e, int skipFrames, bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackTrace>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skipFrames;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr__ctor_Public_Void_Exception_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700120B RID: 4619
		// (get) Token: 0x06004780 RID: 18304 RVA: 0x00148940 File Offset: 0x00146B40
		public unsafe virtual int FrameCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackTrace.NativeMethodInfoPtr_get_FrameCount_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x00148988 File Offset: 0x00146B88
		[CallerCount(0)]
		public unsafe virtual StackFrame GetFrame(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackTrace.NativeMethodInfoPtr_GetFrame_Public_Virtual_New_StackFrame_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StackFrame>(intPtr3) : null;
			}
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x001489E0 File Offset: 0x00146BE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365809, RefRangeEnd = 365810, XrefRangeStart = 365797, XrefRangeEnd = 365809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAotId()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_GetAotId_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x00148A0C File Offset: 0x00146C0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365883, RefRangeEnd = 365885, XrefRangeStart = 365810, XrefRangeEnd = 365883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddFrames(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_AddFrames_Private_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x00148A5C File Offset: 0x00146C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 365928, RefRangeEnd = 365929, XrefRangeStart = 365885, XrefRangeEnd = 365928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetFullNameForStackTrace(StringBuilder sb, MethodBase mi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_GetFullNameForStackTrace_Internal_Void_StringBuilder_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x00148AB0 File Offset: 0x00146CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365929, XrefRangeEnd = 365946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackTrace.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x00148AF4 File Offset: 0x00146CF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 282571, RefRangeEnd = 282572, XrefRangeStart = 282571, XrefRangeEnd = 282572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(StackTrace.TraceFormat traceFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref traceFormat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackTrace.NativeMethodInfoPtr_ToString_Internal_String_TraceFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x0001B00C File Offset: 0x0001920C
		public StackTrace(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001205 RID: 4613
		// (get) Token: 0x06004788 RID: 18312 RVA: 0x00148B38 File Offset: 0x00146D38
		// (set) Token: 0x06004789 RID: 18313 RVA: 0x0001B015 File Offset: 0x00019215
		public unsafe static int METHODS_TO_SKIP
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StackTrace.NativeFieldInfoPtr_METHODS_TO_SKIP, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTrace.NativeFieldInfoPtr_METHODS_TO_SKIP, (void*)(&value));
			}
		}

		// Token: 0x17001206 RID: 4614
		// (get) Token: 0x0600478A RID: 18314 RVA: 0x00148B54 File Offset: 0x00146D54
		// (set) Token: 0x0600478B RID: 18315 RVA: 0x0001B023 File Offset: 0x00019223
		public unsafe Il2CppReferenceArray<StackFrame> frames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_frames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StackFrame>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_frames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001207 RID: 4615
		// (get) Token: 0x0600478C RID: 18316 RVA: 0x00148B84 File Offset: 0x00146D84
		// (set) Token: 0x0600478D RID: 18317 RVA: 0x0001B042 File Offset: 0x00019242
		public unsafe Il2CppReferenceArray<StackTrace> captured_traces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_captured_traces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StackTrace>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_captured_traces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001208 RID: 4616
		// (get) Token: 0x0600478E RID: 18318 RVA: 0x00148BB4 File Offset: 0x00146DB4
		// (set) Token: 0x0600478F RID: 18319 RVA: 0x0001B061 File Offset: 0x00019261
		public unsafe bool debug_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_debug_info);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackTrace.NativeFieldInfoPtr_debug_info)) = value;
			}
		}

		// Token: 0x17001209 RID: 4617
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x00148BDC File Offset: 0x00146DDC
		// (set) Token: 0x06004791 RID: 18321 RVA: 0x0001B07C File Offset: 0x0001927C
		public unsafe static bool isAotidSet
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(StackTrace.NativeFieldInfoPtr_isAotidSet, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTrace.NativeFieldInfoPtr_isAotidSet, (void*)(&value));
			}
		}

		// Token: 0x1700120A RID: 4618
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x00148BF8 File Offset: 0x00146DF8
		// (set) Token: 0x06004793 RID: 18323 RVA: 0x0001B08A File Offset: 0x0001928A
		public unsafe static string aotid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StackTrace.NativeFieldInfoPtr_aotid, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackTrace.NativeFieldInfoPtr_aotid, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040039E9 RID: 14825
		private static readonly IntPtr NativeFieldInfoPtr_METHODS_TO_SKIP;

		// Token: 0x040039EA RID: 14826
		private static readonly IntPtr NativeFieldInfoPtr_frames;

		// Token: 0x040039EB RID: 14827
		private static readonly IntPtr NativeFieldInfoPtr_captured_traces;

		// Token: 0x040039EC RID: 14828
		private static readonly IntPtr NativeFieldInfoPtr_debug_info;

		// Token: 0x040039ED RID: 14829
		private static readonly IntPtr NativeFieldInfoPtr_isAotidSet;

		// Token: 0x040039EE RID: 14830
		private static readonly IntPtr NativeFieldInfoPtr_aotid;

		// Token: 0x040039EF RID: 14831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040039F0 RID: 14832
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040039F1 RID: 14833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x040039F2 RID: 14834
		private static readonly IntPtr NativeMethodInfoPtr_init_frames_Private_Void_Int32_Boolean_0;

		// Token: 0x040039F3 RID: 14835
		private static readonly IntPtr NativeMethodInfoPtr_get_trace_Private_Static_Il2CppReferenceArray_1_StackFrame_Exception_Int32_Boolean_0;

		// Token: 0x040039F4 RID: 14836
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_Boolean_0;

		// Token: 0x040039F5 RID: 14837
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Exception_Int32_Boolean_0;

		// Token: 0x040039F6 RID: 14838
		private static readonly IntPtr NativeMethodInfoPtr_get_FrameCount_Public_Virtual_New_get_Int32_0;

		// Token: 0x040039F7 RID: 14839
		private static readonly IntPtr NativeMethodInfoPtr_GetFrame_Public_Virtual_New_StackFrame_Int32_0;

		// Token: 0x040039F8 RID: 14840
		private static readonly IntPtr NativeMethodInfoPtr_GetAotId_Private_Static_String_0;

		// Token: 0x040039F9 RID: 14841
		private static readonly IntPtr NativeMethodInfoPtr_AddFrames_Private_Boolean_StringBuilder_0;

		// Token: 0x040039FA RID: 14842
		private static readonly IntPtr NativeMethodInfoPtr_GetFullNameForStackTrace_Internal_Void_StringBuilder_MethodBase_0;

		// Token: 0x040039FB RID: 14843
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040039FC RID: 14844
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Internal_String_TraceFormat_0;

		// Token: 0x0200066B RID: 1643
		public enum TraceFormat
		{
			// Token: 0x04004552 RID: 17746
			Normal,
			// Token: 0x04004553 RID: 17747
			TrailingNewLine,
			// Token: 0x04004554 RID: 17748
			NoResourceLookup
		}
	}
}
