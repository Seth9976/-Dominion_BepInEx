using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020004BD RID: 1213
	[Serializable]
	public class StackFrame : Object
	{
		// Token: 0x06004755 RID: 18261 RVA: 0x00147DBC File Offset: 0x00145FBC
		// Note: this type is marked as 'beforefieldinit'.
		static StackFrame()
		{
			Il2CppClassPointerStore<StackFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics", "StackFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StackFrame>.NativeClassPtr);
			StackFrame.NativeFieldInfoPtr_OFFSET_UNKNOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "OFFSET_UNKNOWN");
			StackFrame.NativeFieldInfoPtr_ilOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "ilOffset");
			StackFrame.NativeFieldInfoPtr_nativeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "nativeOffset");
			StackFrame.NativeFieldInfoPtr_methodAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "methodAddress");
			StackFrame.NativeFieldInfoPtr_methodIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "methodIndex");
			StackFrame.NativeFieldInfoPtr_methodBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "methodBase");
			StackFrame.NativeFieldInfoPtr_fileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "fileName");
			StackFrame.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "lineNumber");
			StackFrame.NativeFieldInfoPtr_columnNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "columnNumber");
			StackFrame.NativeFieldInfoPtr_internalMethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, "internalMethodName");
			StackFrame.NativeMethodInfoPtr_get_frame_info_Private_Static_Boolean_Int32_Boolean_byref_MethodBase_byref_Int32_byref_Int32_byref_String_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100673879);
			StackFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100673880);
			StackFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100673881);
			StackFrame.NativeMethodInfoPtr_GetFileLineNumber_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100673882);
			StackFrame.NativeMethodInfoPtr_GetFileName_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100673883);
			StackFrame.NativeMethodInfoPtr_GetSecureFileName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100673884);
			StackFrame.NativeMethodInfoPtr_GetILOffset_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100673885);
			StackFrame.NativeMethodInfoPtr_GetMethod_Public_Virtual_New_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100673886);
			StackFrame.NativeMethodInfoPtr_GetNativeOffset_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100673887);
			StackFrame.NativeMethodInfoPtr_GetMethodAddress_Internal_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100673888);
			StackFrame.NativeMethodInfoPtr_GetMethodIndex_Internal_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100673889);
			StackFrame.NativeMethodInfoPtr_GetInternalMethodName_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100673890);
			StackFrame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StackFrame>.NativeClassPtr, 100673891);
		}

		// Token: 0x06004756 RID: 18262 RVA: 0x00147FB8 File Offset: 0x001461B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365704, XrefRangeEnd = 365705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool get_frame_info(int skip, bool needFileInfo, out MethodBase method, out int iloffset, out int native_offset, out string file, out int line, out int column)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skip;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needFileInfo;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &iloffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &native_offset;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &line;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &column;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_get_frame_info_Private_Static_Boolean_Int32_Boolean_byref_MethodBase_byref_Int32_byref_Int32_byref_String_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			method = ((intPtr5 == 0) ? null : new MethodBase(intPtr5));
			file = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06004757 RID: 18263 RVA: 0x00148080 File Offset: 0x00146280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365705, XrefRangeEnd = 365707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackFrame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackFrame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004758 RID: 18264 RVA: 0x001480BC File Offset: 0x001462BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365709, RefRangeEnd = 365711, XrefRangeStart = 365707, XrefRangeEnd = 365709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StackFrame(int skipFrames, bool fNeedFileInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StackFrame>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipFrames;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fNeedFileInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004759 RID: 18265 RVA: 0x00148114 File Offset: 0x00146314
		[CallerCount(0)]
		public unsafe virtual int GetFileLineNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetFileLineNumber_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x0014815C File Offset: 0x0014635C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetFileName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetFileName_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600475B RID: 18267 RVA: 0x001481A0 File Offset: 0x001463A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 365714, RefRangeEnd = 365716, XrefRangeStart = 365711, XrefRangeEnd = 365714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetSecureFileName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_GetSecureFileName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600475C RID: 18268 RVA: 0x001481D8 File Offset: 0x001463D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetILOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetILOffset_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600475D RID: 18269 RVA: 0x00148220 File Offset: 0x00146420
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual MethodBase GetMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetMethod_Public_Virtual_New_MethodBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x0600475E RID: 18270 RVA: 0x0014826C File Offset: 0x0014646C
		[CallerCount(0)]
		public unsafe virtual int GetNativeOffset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_GetNativeOffset_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600475F RID: 18271 RVA: 0x001482B4 File Offset: 0x001464B4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long GetMethodAddress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_GetMethodAddress_Internal_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004760 RID: 18272 RVA: 0x001482F0 File Offset: 0x001464F0
		[CallerCount(0)]
		public unsafe uint GetMethodIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_GetMethodIndex_Internal_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004761 RID: 18273 RVA: 0x0014832C File Offset: 0x0014652C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetInternalMethodName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StackFrame.NativeMethodInfoPtr_GetInternalMethodName_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004762 RID: 18274 RVA: 0x00148364 File Offset: 0x00146564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 365716, XrefRangeEnd = 365754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StackFrame.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004763 RID: 18275 RVA: 0x0001AEF6 File Offset: 0x000190F6
		public StackFrame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x06004764 RID: 18276 RVA: 0x001483A8 File Offset: 0x001465A8
		// (set) Token: 0x06004765 RID: 18277 RVA: 0x0001AEFF File Offset: 0x000190FF
		public unsafe static int OFFSET_UNKNOWN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(StackFrame.NativeFieldInfoPtr_OFFSET_UNKNOWN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StackFrame.NativeFieldInfoPtr_OFFSET_UNKNOWN, (void*)(&value));
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06004766 RID: 18278 RVA: 0x001483C4 File Offset: 0x001465C4
		// (set) Token: 0x06004767 RID: 18279 RVA: 0x0001AF0D File Offset: 0x0001910D
		public unsafe int ilOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_ilOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_ilOffset)) = value;
			}
		}

		// Token: 0x170011FD RID: 4605
		// (get) Token: 0x06004768 RID: 18280 RVA: 0x001483EC File Offset: 0x001465EC
		// (set) Token: 0x06004769 RID: 18281 RVA: 0x0001AF28 File Offset: 0x00019128
		public unsafe int nativeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_nativeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_nativeOffset)) = value;
			}
		}

		// Token: 0x170011FE RID: 4606
		// (get) Token: 0x0600476A RID: 18282 RVA: 0x00148414 File Offset: 0x00146614
		// (set) Token: 0x0600476B RID: 18283 RVA: 0x0001AF43 File Offset: 0x00019143
		public unsafe long methodAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodAddress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodAddress)) = value;
			}
		}

		// Token: 0x170011FF RID: 4607
		// (get) Token: 0x0600476C RID: 18284 RVA: 0x0014843C File Offset: 0x0014663C
		// (set) Token: 0x0600476D RID: 18285 RVA: 0x0001AF5E File Offset: 0x0001915E
		public unsafe uint methodIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodIndex)) = value;
			}
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x0600476E RID: 18286 RVA: 0x00148464 File Offset: 0x00146664
		// (set) Token: 0x0600476F RID: 18287 RVA: 0x0001AF79 File Offset: 0x00019179
		public unsafe MethodBase methodBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_methodBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x06004770 RID: 18288 RVA: 0x00148494 File Offset: 0x00146694
		// (set) Token: 0x06004771 RID: 18289 RVA: 0x0001AF98 File Offset: 0x00019198
		public unsafe string fileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_fileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_fileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x06004772 RID: 18290 RVA: 0x001484BC File Offset: 0x001466BC
		// (set) Token: 0x06004773 RID: 18291 RVA: 0x0001AFB7 File Offset: 0x000191B7
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x06004774 RID: 18292 RVA: 0x001484E4 File Offset: 0x001466E4
		// (set) Token: 0x06004775 RID: 18293 RVA: 0x0001AFD2 File Offset: 0x000191D2
		public unsafe int columnNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_columnNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_columnNumber)) = value;
			}
		}

		// Token: 0x17001204 RID: 4612
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x0014850C File Offset: 0x0014670C
		// (set) Token: 0x06004777 RID: 18295 RVA: 0x0001AFED File Offset: 0x000191ED
		public unsafe string internalMethodName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_internalMethodName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StackFrame.NativeFieldInfoPtr_internalMethodName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040039D2 RID: 14802
		private static readonly IntPtr NativeFieldInfoPtr_OFFSET_UNKNOWN;

		// Token: 0x040039D3 RID: 14803
		private static readonly IntPtr NativeFieldInfoPtr_ilOffset;

		// Token: 0x040039D4 RID: 14804
		private static readonly IntPtr NativeFieldInfoPtr_nativeOffset;

		// Token: 0x040039D5 RID: 14805
		private static readonly IntPtr NativeFieldInfoPtr_methodAddress;

		// Token: 0x040039D6 RID: 14806
		private static readonly IntPtr NativeFieldInfoPtr_methodIndex;

		// Token: 0x040039D7 RID: 14807
		private static readonly IntPtr NativeFieldInfoPtr_methodBase;

		// Token: 0x040039D8 RID: 14808
		private static readonly IntPtr NativeFieldInfoPtr_fileName;

		// Token: 0x040039D9 RID: 14809
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x040039DA RID: 14810
		private static readonly IntPtr NativeFieldInfoPtr_columnNumber;

		// Token: 0x040039DB RID: 14811
		private static readonly IntPtr NativeFieldInfoPtr_internalMethodName;

		// Token: 0x040039DC RID: 14812
		private static readonly IntPtr NativeMethodInfoPtr_get_frame_info_Private_Static_Boolean_Int32_Boolean_byref_MethodBase_byref_Int32_byref_Int32_byref_String_byref_Int32_byref_Int32_0;

		// Token: 0x040039DD RID: 14813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040039DE RID: 14814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Boolean_0;

		// Token: 0x040039DF RID: 14815
		private static readonly IntPtr NativeMethodInfoPtr_GetFileLineNumber_Public_Virtual_New_Int32_0;

		// Token: 0x040039E0 RID: 14816
		private static readonly IntPtr NativeMethodInfoPtr_GetFileName_Public_Virtual_New_String_0;

		// Token: 0x040039E1 RID: 14817
		private static readonly IntPtr NativeMethodInfoPtr_GetSecureFileName_Internal_String_0;

		// Token: 0x040039E2 RID: 14818
		private static readonly IntPtr NativeMethodInfoPtr_GetILOffset_Public_Virtual_New_Int32_0;

		// Token: 0x040039E3 RID: 14819
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Public_Virtual_New_MethodBase_0;

		// Token: 0x040039E4 RID: 14820
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeOffset_Public_Virtual_New_Int32_0;

		// Token: 0x040039E5 RID: 14821
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodAddress_Internal_Int64_0;

		// Token: 0x040039E6 RID: 14822
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodIndex_Internal_UInt32_0;

		// Token: 0x040039E7 RID: 14823
		private static readonly IntPtr NativeMethodInfoPtr_GetInternalMethodName_Internal_String_0;

		// Token: 0x040039E8 RID: 14824
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
