using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003E9 RID: 1001
	public class CADMessageBase : Object
	{
		// Token: 0x06003F79 RID: 16249 RVA: 0x00127068 File Offset: 0x00125268
		// Note: this type is marked as 'beforefieldinit'.
		static CADMessageBase()
		{
			Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMessageBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr);
			CADMessageBase.NativeFieldInfoPtr__args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_args");
			CADMessageBase.NativeFieldInfoPtr__serializedArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_serializedArgs");
			CADMessageBase.NativeFieldInfoPtr__propertyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_propertyCount");
			CADMessageBase.NativeFieldInfoPtr__callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_callContext");
			CADMessageBase.NativeFieldInfoPtr_serializedMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "serializedMethod");
			CADMessageBase.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672572);
			CADMessageBase.NativeMethodInfoPtr_GetMethod_Internal_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672573);
			CADMessageBase.NativeMethodInfoPtr_GetSignature_Protected_Static_Il2CppReferenceArray_1_Type_MethodBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672574);
			CADMessageBase.NativeMethodInfoPtr_MarshalProperties_Internal_Static_Int32_IDictionary_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672575);
			CADMessageBase.NativeMethodInfoPtr_UnmarshalProperties_Internal_Static_Void_IDictionary_Int32_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672576);
			CADMessageBase.NativeMethodInfoPtr_IsPossibleToIgnoreMarshal_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672577);
			CADMessageBase.NativeMethodInfoPtr_MarshalArgument_Protected_Object_Object_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672578);
			CADMessageBase.NativeMethodInfoPtr_UnmarshalArgument_Protected_Object_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672579);
			CADMessageBase.NativeMethodInfoPtr_MarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672580);
			CADMessageBase.NativeMethodInfoPtr_UnmarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672581);
			CADMessageBase.NativeMethodInfoPtr_SaveLogicalCallContext_Protected_Void_IMethodMessage_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672582);
			CADMessageBase.NativeMethodInfoPtr_GetLogicalCallContext_Internal_LogicalCallContext_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100672583);
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x001271EC File Offset: 0x001253EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354381, RefRangeEnd = 354383, XrefRangeStart = 354375, XrefRangeEnd = 354381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADMessageBase(IMethodMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x00127238 File Offset: 0x00125438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354397, RefRangeEnd = 354398, XrefRangeStart = 354383, XrefRangeEnd = 354397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodBase GetMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_GetMethod_Internal_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x00127278 File Offset: 0x00125478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354413, RefRangeEnd = 354414, XrefRangeStart = 354398, XrefRangeEnd = 354413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Type> GetSignature(MethodBase methodBase, bool load)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref load;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_GetSignature_Protected_Static_Il2CppReferenceArray_1_Type_MethodBase_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x001272CC File Offset: 0x001254CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354462, RefRangeEnd = 354464, XrefRangeStart = 354414, XrefRangeEnd = 354462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MarshalProperties(IDictionary dict, ref ArrayList args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_MarshalProperties_Internal_Static_Int32_IDictionary_byref_ArrayList_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			args = ((intPtr4 == 0) ? null : new ArrayList(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x00127338 File Offset: 0x00125538
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354470, RefRangeEnd = 354472, XrefRangeStart = 354464, XrefRangeEnd = 354470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnmarshalProperties(IDictionary dict, int count, ArrayList args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_UnmarshalProperties_Internal_Static_Void_IDictionary_Int32_ArrayList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x00127390 File Offset: 0x00125590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354489, RefRangeEnd = 354490, XrefRangeStart = 354472, XrefRangeEnd = 354489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPossibleToIgnoreMarshal(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_IsPossibleToIgnoreMarshal_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003F80 RID: 16256 RVA: 0x001273D4 File Offset: 0x001255D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354508, RefRangeEnd = 354510, XrefRangeStart = 354490, XrefRangeEnd = 354508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object MarshalArgument(Object arg, ref ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_MarshalArgument_Protected_Object_Object_byref_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			args = ((intPtr4 == 0) ? null : new ArrayList(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06003F81 RID: 16257 RVA: 0x00127450 File Offset: 0x00125650
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354546, RefRangeEnd = 354548, XrefRangeStart = 354510, XrefRangeEnd = 354546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object UnmarshalArgument(Object arg, ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_UnmarshalArgument_Protected_Object_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003F82 RID: 16258 RVA: 0x001274B4 File Offset: 0x001256B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354553, RefRangeEnd = 354555, XrefRangeStart = 354548, XrefRangeEnd = 354553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> MarshalArguments(Il2CppReferenceArray<Object> arguments, ref ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_MarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_byref_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			args = ((intPtr4 == 0) ? null : new ArrayList(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr5) : null;
		}

		// Token: 0x06003F83 RID: 16259 RVA: 0x00127530 File Offset: 0x00125730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354560, RefRangeEnd = 354562, XrefRangeStart = 354555, XrefRangeEnd = 354560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> UnmarshalArguments(Il2CppReferenceArray<Object> arguments, ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_UnmarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06003F84 RID: 16260 RVA: 0x00127594 File Offset: 0x00125794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354578, RefRangeEnd = 354579, XrefRangeStart = 354562, XrefRangeEnd = 354578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(serializeList);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_SaveLogicalCallContext_Protected_Void_IMethodMessage_byref_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			serializeList = ((intPtr4 == 0) ? null : new ArrayList(intPtr4));
		}

		// Token: 0x06003F85 RID: 16261 RVA: 0x00127600 File Offset: 0x00125800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354582, RefRangeEnd = 354584, XrefRangeStart = 354579, XrefRangeEnd = 354582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogicalCallContext GetLogicalCallContext(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_GetLogicalCallContext_Internal_LogicalCallContext_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x06003F86 RID: 16262 RVA: 0x000180EA File Offset: 0x000162EA
		public CADMessageBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x06003F87 RID: 16263 RVA: 0x00127650 File Offset: 0x00125850
		// (set) Token: 0x06003F88 RID: 16264 RVA: 0x000180F3 File Offset: 0x000162F3
		public unsafe Il2CppReferenceArray<Object> _args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06003F89 RID: 16265 RVA: 0x00127680 File Offset: 0x00125880
		// (set) Token: 0x06003F8A RID: 16266 RVA: 0x00018112 File Offset: 0x00016312
		public unsafe Il2CppStructArray<byte> _serializedArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__serializedArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__serializedArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06003F8B RID: 16267 RVA: 0x001276B0 File Offset: 0x001258B0
		// (set) Token: 0x06003F8C RID: 16268 RVA: 0x00018131 File Offset: 0x00016331
		public unsafe int _propertyCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__propertyCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__propertyCount)) = value;
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06003F8D RID: 16269 RVA: 0x001276D8 File Offset: 0x001258D8
		// (set) Token: 0x06003F8E RID: 16270 RVA: 0x0001814C File Offset: 0x0001634C
		public unsafe CADArgHolder _callContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__callContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CADArgHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__callContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06003F8F RID: 16271 RVA: 0x00127708 File Offset: 0x00125908
		// (set) Token: 0x06003F90 RID: 16272 RVA: 0x0001816B File Offset: 0x0001636B
		public unsafe Il2CppStructArray<byte> serializedMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr_serializedMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr_serializedMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003418 RID: 13336
		private static readonly IntPtr NativeFieldInfoPtr__args;

		// Token: 0x04003419 RID: 13337
		private static readonly IntPtr NativeFieldInfoPtr__serializedArgs;

		// Token: 0x0400341A RID: 13338
		private static readonly IntPtr NativeFieldInfoPtr__propertyCount;

		// Token: 0x0400341B RID: 13339
		private static readonly IntPtr NativeFieldInfoPtr__callContext;

		// Token: 0x0400341C RID: 13340
		private static readonly IntPtr NativeFieldInfoPtr_serializedMethod;

		// Token: 0x0400341D RID: 13341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;

		// Token: 0x0400341E RID: 13342
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Internal_MethodBase_0;

		// Token: 0x0400341F RID: 13343
		private static readonly IntPtr NativeMethodInfoPtr_GetSignature_Protected_Static_Il2CppReferenceArray_1_Type_MethodBase_Boolean_0;

		// Token: 0x04003420 RID: 13344
		private static readonly IntPtr NativeMethodInfoPtr_MarshalProperties_Internal_Static_Int32_IDictionary_byref_ArrayList_0;

		// Token: 0x04003421 RID: 13345
		private static readonly IntPtr NativeMethodInfoPtr_UnmarshalProperties_Internal_Static_Void_IDictionary_Int32_ArrayList_0;

		// Token: 0x04003422 RID: 13346
		private static readonly IntPtr NativeMethodInfoPtr_IsPossibleToIgnoreMarshal_Private_Static_Boolean_Object_0;

		// Token: 0x04003423 RID: 13347
		private static readonly IntPtr NativeMethodInfoPtr_MarshalArgument_Protected_Object_Object_byref_ArrayList_0;

		// Token: 0x04003424 RID: 13348
		private static readonly IntPtr NativeMethodInfoPtr_UnmarshalArgument_Protected_Object_Object_ArrayList_0;

		// Token: 0x04003425 RID: 13349
		private static readonly IntPtr NativeMethodInfoPtr_MarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_byref_ArrayList_0;

		// Token: 0x04003426 RID: 13350
		private static readonly IntPtr NativeMethodInfoPtr_UnmarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_ArrayList_0;

		// Token: 0x04003427 RID: 13351
		private static readonly IntPtr NativeMethodInfoPtr_SaveLogicalCallContext_Protected_Void_IMethodMessage_byref_ArrayList_0;

		// Token: 0x04003428 RID: 13352
		private static readonly IntPtr NativeMethodInfoPtr_GetLogicalCallContext_Internal_LogicalCallContext_ArrayList_0;
	}
}
