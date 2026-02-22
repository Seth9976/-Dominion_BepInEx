using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.XR
{
	// Token: 0x0200000A RID: 10
	public sealed class InputFeatureUsage : ValueType
	{
		// Token: 0x0600003C RID: 60 RVA: 0x000033CC File Offset: 0x000015CC
		// Note: this type is marked as 'beforefieldinit'.
		static InputFeatureUsage()
		{
			Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "InputFeatureUsage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr);
			InputFeatureUsage.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, "m_Name");
			InputFeatureUsage.NativeFieldInfoPtr_m_InternalType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, "m_InternalType");
			InputFeatureUsage.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, 100663304);
			InputFeatureUsage.NativeMethodInfoPtr_get_internalType_Internal_get_InputFeatureType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, 100663305);
			InputFeatureUsage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, 100663306);
			InputFeatureUsage.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputFeatureUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, 100663307);
			InputFeatureUsage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr, 100663308);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00003488 File Offset: 0x00001688
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000022F9 File Offset: 0x000004F9
		public unsafe string name
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 59099, RefRangeEnd = 59118, XrefRangeStart = 59099, XrefRangeEnd = 59118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFeatureUsage.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003E RID: 62 RVA: 0x000034C4 File Offset: 0x000016C4
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002303 File Offset: 0x00000503
		public unsafe InputFeatureType internalType
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 62297, RefRangeEnd = 62303, XrefRangeStart = 62297, XrefRangeEnd = 62303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFeatureUsage.NativeMethodInfoPtr_get_internalType_Internal_get_InputFeatureType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_InternalType = value;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003508 File Offset: 0x00001708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158283, XrefRangeEnd = 158287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFeatureUsage.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000355C File Offset: 0x0000175C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158287, XrefRangeEnd = 158288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(InputFeatureUsage other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFeatureUsage.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputFeatureUsage_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000035B4 File Offset: 0x000017B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158288, XrefRangeEnd = 158289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputFeatureUsage.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000022A4 File Offset: 0x000004A4
		public InputFeatureUsage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000022AD File Offset: 0x000004AD
		public InputFeatureUsage()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputFeatureUsage>.NativeClassPtr))
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000035F8 File Offset: 0x000017F8
		// (set) Token: 0x06000045 RID: 69 RVA: 0x000022BF File Offset: 0x000004BF
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFeatureUsage.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFeatureUsage.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00003620 File Offset: 0x00001820
		// (set) Token: 0x06000047 RID: 71 RVA: 0x000022DE File Offset: 0x000004DE
		public unsafe InputFeatureType m_InternalType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFeatureUsage.NativeFieldInfoPtr_m_InternalType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputFeatureUsage.NativeFieldInfoPtr_m_InternalType)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003648 File Offset: 0x00001848
		public Type type
		{
			get
			{
				Type type;
				switch (this.m_InternalType)
				{
				case InputFeatureType.Custom:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Il2CppStructArray<byte>>());
					break;
				case InputFeatureType.Binary:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<bool>());
					break;
				case InputFeatureType.DiscreteStates:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<uint>());
					break;
				case InputFeatureType.Axis1D:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
					break;
				case InputFeatureType.Axis2D:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Vector2>());
					break;
				case InputFeatureType.Axis3D:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Vector3>());
					break;
				case InputFeatureType.Rotation:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Quaternion>());
					break;
				case InputFeatureType.Hand:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Hand>());
					break;
				case InputFeatureType.Bone:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Bone>());
					break;
				case InputFeatureType.Eyes:
					type = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Eyes>());
					break;
				default:
					throw new InvalidCastException("No valid managed type for unknown native type.");
				}
				return type;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003724 File Offset: 0x00001924
		public static bool operator ==(InputFeatureUsage a, InputFeatureUsage b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00003740 File Offset: 0x00001940
		public static bool operator !=(InputFeatureUsage a, InputFeatureUsage b)
		{
			return !(a == b);
		}

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalType;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_get_internalType_Internal_get_InputFeatureType_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InputFeatureUsage_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
