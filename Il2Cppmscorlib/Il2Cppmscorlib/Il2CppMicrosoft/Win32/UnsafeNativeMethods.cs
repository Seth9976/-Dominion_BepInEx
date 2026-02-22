using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Diagnostics.Tracing;

namespace Il2CppMicrosoft.Win32
{
	// Token: 0x0200003D RID: 61
	public static class UnsafeNativeMethods : Object
	{
		// Token: 0x0600041C RID: 1052 RVA: 0x00003AA7 File Offset: 0x00001CA7
		// Note: this type is marked as 'beforefieldinit'.
		static UnsafeNativeMethods()
		{
			Il2CppClassPointerStore<UnsafeNativeMethods>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Microsoft.Win32", "UnsafeNativeMethods");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNativeMethods>.NativeClassPtr);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00003ACC File Offset: 0x00001CCC
		public UnsafeNativeMethods(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0200054A RID: 1354
		public static class ManifestEtw : Object
		{
			// Token: 0x06004E36 RID: 20022 RVA: 0x00160794 File Offset: 0x0015E994
			// Note: this type is marked as 'beforefieldinit'.
			static ManifestEtw()
			{
				Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNativeMethods>.NativeClassPtr, "ManifestEtw");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventRegister_Internal_Static_UInt32_byref_Guid_EtwEnableCallback_ptr_Void_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663879);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventUnregister_Internal_Static_UInt32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663880);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventWriteTransferWrapper_Internal_Static_Int32_Int64_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663881);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventWriteTransfer_Private_Static_Int32_Int64_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_ptr_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663882);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventActivityIdControl_Internal_Static_Int32_ActivityControl_byref_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663883);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventSetInformation_Internal_Static_Int32_Int64_EVENT_INFO_CLASS_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663884);
				UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EnumerateTraceGuidsEx_Internal_Static_Int32_TRACE_QUERY_INFO_CLASS_ptr_Void_Int32_ptr_Void_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, 100663885);
			}

			// Token: 0x06004E37 RID: 20023 RVA: 0x0016084C File Offset: 0x0015EA4C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 264651, RefRangeEnd = 264652, XrefRangeStart = 264649, XrefRangeEnd = 264651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint EventRegister([In] ref Guid providerId, [In] UnsafeNativeMethods.ManifestEtw.EtwEnableCallback enableCallback, [In] void* callbackContext, [In] [Out] ref long registrationHandle)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &providerId;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enableCallback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = callbackContext;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &registrationHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventRegister_Internal_Static_UInt32_byref_Guid_EtwEnableCallback_ptr_Void_byref_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E38 RID: 20024 RVA: 0x001608B8 File Offset: 0x0015EAB8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 264654, RefRangeEnd = 264657, XrefRangeStart = 264652, XrefRangeEnd = 264654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint EventUnregister([In] long registrationHandle)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref registrationHandle;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventUnregister_Internal_Static_UInt32_Int64_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E39 RID: 20025 RVA: 0x001608F8 File Offset: 0x0015EAF8
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 264663, RefRangeEnd = 264669, XrefRangeStart = 264657, XrefRangeEnd = 264663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int EventWriteTransferWrapper(long registrationHandle, ref EventDescriptor eventDescriptor, Guid* activityId, Guid* relatedActivityId, int userDataCount, EventProvider.EventData* userData)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref registrationHandle;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &eventDescriptor;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = relatedActivityId;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userDataCount;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventWriteTransferWrapper_Internal_Static_Int32_Int64_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_ptr_EventData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E3A RID: 20026 RVA: 0x0016097C File Offset: 0x0015EB7C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 264671, RefRangeEnd = 264673, XrefRangeStart = 264669, XrefRangeEnd = 264671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int EventWriteTransfer([In] long registrationHandle, [In] ref EventDescriptor eventDescriptor, [In] Guid* activityId, [In] Guid* relatedActivityId, [In] int userDataCount, [In] EventProvider.EventData* userData)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref registrationHandle;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &eventDescriptor;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = activityId;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = relatedActivityId;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref userDataCount;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = userData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventWriteTransfer_Private_Static_Int32_Int64_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_ptr_EventData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E3B RID: 20027 RVA: 0x00160A00 File Offset: 0x0015EC00
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 264675, RefRangeEnd = 264678, XrefRangeStart = 264673, XrefRangeEnd = 264675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int EventActivityIdControl([In] UnsafeNativeMethods.ManifestEtw.ActivityControl ControlCode, [In] [Out] ref Guid ActivityId)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref ControlCode;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ActivityId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventActivityIdControl_Internal_Static_Int32_ActivityControl_byref_Guid_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E3C RID: 20028 RVA: 0x00160A4C File Offset: 0x0015EC4C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 264680, RefRangeEnd = 264681, XrefRangeStart = 264678, XrefRangeEnd = 264680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int EventSetInformation([In] long registrationHandle, [In] UnsafeNativeMethods.ManifestEtw.EVENT_INFO_CLASS informationClass, [In] void* eventInformation, [In] int informationLength)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref registrationHandle;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref informationClass;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = eventInformation;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref informationLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EventSetInformation_Internal_Static_Int32_Int64_EVENT_INFO_CLASS_ptr_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E3D RID: 20029 RVA: 0x00160AB4 File Offset: 0x0015ECB4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 264683, RefRangeEnd = 264684, XrefRangeStart = 264681, XrefRangeEnd = 264683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int EnumerateTraceGuidsEx(UnsafeNativeMethods.ManifestEtw.TRACE_QUERY_INFO_CLASS TraceQueryInfoClass, void* InBuffer, int InBufferSize, void* OutBuffer, int OutBufferSize, ref int ReturnLength)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref TraceQueryInfoClass;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = InBuffer;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref InBufferSize;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = OutBuffer;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref OutBufferSize;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ReturnLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.NativeMethodInfoPtr_EnumerateTraceGuidsEx_Internal_Static_Int32_TRACE_QUERY_INFO_CLASS_ptr_Void_Int32_ptr_Void_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06004E3E RID: 20030 RVA: 0x0001DA33 File Offset: 0x0001BC33
			public ManifestEtw(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003F22 RID: 16162
			private static readonly IntPtr NativeMethodInfoPtr_EventRegister_Internal_Static_UInt32_byref_Guid_EtwEnableCallback_ptr_Void_byref_Int64_0;

			// Token: 0x04003F23 RID: 16163
			private static readonly IntPtr NativeMethodInfoPtr_EventUnregister_Internal_Static_UInt32_Int64_0;

			// Token: 0x04003F24 RID: 16164
			private static readonly IntPtr NativeMethodInfoPtr_EventWriteTransferWrapper_Internal_Static_Int32_Int64_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_ptr_EventData_0;

			// Token: 0x04003F25 RID: 16165
			private static readonly IntPtr NativeMethodInfoPtr_EventWriteTransfer_Private_Static_Int32_Int64_byref_EventDescriptor_ptr_Guid_ptr_Guid_Int32_ptr_EventData_0;

			// Token: 0x04003F26 RID: 16166
			private static readonly IntPtr NativeMethodInfoPtr_EventActivityIdControl_Internal_Static_Int32_ActivityControl_byref_Guid_0;

			// Token: 0x04003F27 RID: 16167
			private static readonly IntPtr NativeMethodInfoPtr_EventSetInformation_Internal_Static_Int32_Int64_EVENT_INFO_CLASS_ptr_Void_Int32_0;

			// Token: 0x04003F28 RID: 16168
			private static readonly IntPtr NativeMethodInfoPtr_EnumerateTraceGuidsEx_Internal_Static_Int32_TRACE_QUERY_INFO_CLASS_ptr_Void_Int32_ptr_Void_Int32_byref_Int32_0;

			// Token: 0x020006BC RID: 1724
			public sealed class EtwEnableCallback : MulticastDelegate
			{
				// Token: 0x060057C5 RID: 22469 RVA: 0x000225F5 File Offset: 0x000207F5
				// Note: this type is marked as 'beforefieldinit'.
				static EtwEnableCallback()
				{
					Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EtwEnableCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, "EtwEnableCallback");
					UnsafeNativeMethods.ManifestEtw.EtwEnableCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EtwEnableCallback>.NativeClassPtr, 100663886);
					UnsafeNativeMethods.ManifestEtw.EtwEnableCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EtwEnableCallback>.NativeClassPtr, 100663887);
				}

				// Token: 0x060057C6 RID: 22470 RVA: 0x0018031C File Offset: 0x0017E51C
				[CallerCount(1135)]
				[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe EtwEnableCallback(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EtwEnableCallback>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.EtwEnableCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060057C7 RID: 22471 RVA: 0x00180378 File Offset: 0x0017E578
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264644, XrefRangeEnd = 264649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void Invoke([In] ref Guid sourceId, [In] int isEnabled, [In] byte level, [In] long matchAnyKeywords, [In] long matchAllKeywords, [In] UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR* filterData, [In] void* callbackContext)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
						*ptr = &sourceId;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isEnabled;
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAnyKeywords;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchAllKeywords;
					ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filterData;
					ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = callbackContext;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnsafeNativeMethods.ManifestEtw.EtwEnableCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060057C8 RID: 22472 RVA: 0x00022633 File Offset: 0x00020833
				public EtwEnableCallback(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x040045E9 RID: 17897
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040045EA RID: 17898
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_byref_Guid_Int32_Byte_Int64_Int64_ptr_EVENT_FILTER_DESCRIPTOR_ptr_Void_0;
			}

			// Token: 0x020006BD RID: 1725
			[StructLayout(2)]
			public struct EVENT_FILTER_DESCRIPTOR
			{
				// Token: 0x060057C9 RID: 22473 RVA: 0x0018040C File Offset: 0x0017E60C
				// Note: this type is marked as 'beforefieldinit'.
				static EVENT_FILTER_DESCRIPTOR()
				{
					Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, "EVENT_FILTER_DESCRIPTOR");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR>.NativeClassPtr);
					UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR.NativeFieldInfoPtr_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR>.NativeClassPtr, "Ptr");
					UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR.NativeFieldInfoPtr_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR>.NativeClassPtr, "Size");
					UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR>.NativeClassPtr, "Type");
				}

				// Token: 0x060057CA RID: 22474 RVA: 0x0002263C File Offset: 0x0002083C
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.EVENT_FILTER_DESCRIPTOR>.NativeClassPtr, ref this));
				}

				// Token: 0x040045EB RID: 17899
				private static readonly IntPtr NativeFieldInfoPtr_Ptr;

				// Token: 0x040045EC RID: 17900
				private static readonly IntPtr NativeFieldInfoPtr_Size;

				// Token: 0x040045ED RID: 17901
				private static readonly IntPtr NativeFieldInfoPtr_Type;

				// Token: 0x040045EE RID: 17902
				[FieldOffset(0)]
				public long Ptr;

				// Token: 0x040045EF RID: 17903
				[FieldOffset(8)]
				public int Size;

				// Token: 0x040045F0 RID: 17904
				[FieldOffset(12)]
				public int Type;
			}

			// Token: 0x020006BE RID: 1726
			public enum ActivityControl : uint
			{
				// Token: 0x040045F2 RID: 17906
				EVENT_ACTIVITY_CTRL_GET_ID = 1U,
				// Token: 0x040045F3 RID: 17907
				EVENT_ACTIVITY_CTRL_SET_ID,
				// Token: 0x040045F4 RID: 17908
				EVENT_ACTIVITY_CTRL_CREATE_ID,
				// Token: 0x040045F5 RID: 17909
				EVENT_ACTIVITY_CTRL_GET_SET_ID,
				// Token: 0x040045F6 RID: 17910
				EVENT_ACTIVITY_CTRL_CREATE_SET_ID
			}

			// Token: 0x020006BF RID: 1727
			public enum EVENT_INFO_CLASS
			{
				// Token: 0x040045F8 RID: 17912
				BinaryTrackInfo,
				// Token: 0x040045F9 RID: 17913
				SetEnableAllKeywords,
				// Token: 0x040045FA RID: 17914
				SetTraits
			}

			// Token: 0x020006C0 RID: 1728
			public enum TRACE_QUERY_INFO_CLASS
			{
				// Token: 0x040045FC RID: 17916
				TraceGuidQueryList,
				// Token: 0x040045FD RID: 17917
				TraceGuidQueryInfo,
				// Token: 0x040045FE RID: 17918
				TraceGuidQueryProcess,
				// Token: 0x040045FF RID: 17919
				TraceStackTracingInfo,
				// Token: 0x04004600 RID: 17920
				MaxTraceSetInfoClass
			}

			// Token: 0x020006C1 RID: 1729
			[StructLayout(2)]
			public struct TRACE_GUID_INFO
			{
				// Token: 0x060057CB RID: 22475 RVA: 0x00180474 File Offset: 0x0017E674
				// Note: this type is marked as 'beforefieldinit'.
				static TRACE_GUID_INFO()
				{
					Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, "TRACE_GUID_INFO");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO>.NativeClassPtr);
					UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO.NativeFieldInfoPtr_InstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO>.NativeClassPtr, "InstanceCount");
					UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO.NativeFieldInfoPtr_Reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO>.NativeClassPtr, "Reserved");
				}

				// Token: 0x060057CC RID: 22476 RVA: 0x0002264E File Offset: 0x0002084E
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_GUID_INFO>.NativeClassPtr, ref this));
				}

				// Token: 0x04004601 RID: 17921
				private static readonly IntPtr NativeFieldInfoPtr_InstanceCount;

				// Token: 0x04004602 RID: 17922
				private static readonly IntPtr NativeFieldInfoPtr_Reserved;

				// Token: 0x04004603 RID: 17923
				[FieldOffset(0)]
				public int InstanceCount;

				// Token: 0x04004604 RID: 17924
				[FieldOffset(4)]
				public int Reserved;
			}

			// Token: 0x020006C2 RID: 1730
			[StructLayout(2)]
			public struct TRACE_PROVIDER_INSTANCE_INFO
			{
				// Token: 0x060057CD RID: 22477 RVA: 0x001804C8 File Offset: 0x0017E6C8
				// Note: this type is marked as 'beforefieldinit'.
				static TRACE_PROVIDER_INSTANCE_INFO()
				{
					Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, "TRACE_PROVIDER_INSTANCE_INFO");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr);
					UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO.NativeFieldInfoPtr_NextOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr, "NextOffset");
					UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO.NativeFieldInfoPtr_EnableCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr, "EnableCount");
					UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO.NativeFieldInfoPtr_Pid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr, "Pid");
					UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO.NativeFieldInfoPtr_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr, "Flags");
				}

				// Token: 0x060057CE RID: 22478 RVA: 0x00022660 File Offset: 0x00020860
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_PROVIDER_INSTANCE_INFO>.NativeClassPtr, ref this));
				}

				// Token: 0x04004605 RID: 17925
				private static readonly IntPtr NativeFieldInfoPtr_NextOffset;

				// Token: 0x04004606 RID: 17926
				private static readonly IntPtr NativeFieldInfoPtr_EnableCount;

				// Token: 0x04004607 RID: 17927
				private static readonly IntPtr NativeFieldInfoPtr_Pid;

				// Token: 0x04004608 RID: 17928
				private static readonly IntPtr NativeFieldInfoPtr_Flags;

				// Token: 0x04004609 RID: 17929
				[FieldOffset(0)]
				public int NextOffset;

				// Token: 0x0400460A RID: 17930
				[FieldOffset(4)]
				public int EnableCount;

				// Token: 0x0400460B RID: 17931
				[FieldOffset(8)]
				public int Pid;

				// Token: 0x0400460C RID: 17932
				[FieldOffset(12)]
				public int Flags;
			}

			// Token: 0x020006C3 RID: 1731
			[StructLayout(2)]
			public struct TRACE_ENABLE_INFO
			{
				// Token: 0x060057CF RID: 22479 RVA: 0x00180544 File Offset: 0x0017E744
				// Note: this type is marked as 'beforefieldinit'.
				static TRACE_ENABLE_INFO()
				{
					Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw>.NativeClassPtr, "TRACE_ENABLE_INFO");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr);
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "IsEnabled");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_Level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "Level");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_Reserved1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "Reserved1");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_LoggerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "LoggerId");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_EnableProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "EnableProperty");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_Reserved2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "Reserved2");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_MatchAnyKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "MatchAnyKeyword");
					UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO.NativeFieldInfoPtr_MatchAllKeyword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, "MatchAllKeyword");
				}

				// Token: 0x060057D0 RID: 22480 RVA: 0x00022672 File Offset: 0x00020872
				public Object BoxIl2CppObject()
				{
					return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnsafeNativeMethods.ManifestEtw.TRACE_ENABLE_INFO>.NativeClassPtr, ref this));
				}

				// Token: 0x0400460D RID: 17933
				private static readonly IntPtr NativeFieldInfoPtr_IsEnabled;

				// Token: 0x0400460E RID: 17934
				private static readonly IntPtr NativeFieldInfoPtr_Level;

				// Token: 0x0400460F RID: 17935
				private static readonly IntPtr NativeFieldInfoPtr_Reserved1;

				// Token: 0x04004610 RID: 17936
				private static readonly IntPtr NativeFieldInfoPtr_LoggerId;

				// Token: 0x04004611 RID: 17937
				private static readonly IntPtr NativeFieldInfoPtr_EnableProperty;

				// Token: 0x04004612 RID: 17938
				private static readonly IntPtr NativeFieldInfoPtr_Reserved2;

				// Token: 0x04004613 RID: 17939
				private static readonly IntPtr NativeFieldInfoPtr_MatchAnyKeyword;

				// Token: 0x04004614 RID: 17940
				private static readonly IntPtr NativeFieldInfoPtr_MatchAllKeyword;

				// Token: 0x04004615 RID: 17941
				[FieldOffset(0)]
				public int IsEnabled;

				// Token: 0x04004616 RID: 17942
				[FieldOffset(4)]
				public byte Level;

				// Token: 0x04004617 RID: 17943
				[FieldOffset(5)]
				public byte Reserved1;

				// Token: 0x04004618 RID: 17944
				[FieldOffset(6)]
				public ushort LoggerId;

				// Token: 0x04004619 RID: 17945
				[FieldOffset(8)]
				public int EnableProperty;

				// Token: 0x0400461A RID: 17946
				[FieldOffset(12)]
				public int Reserved2;

				// Token: 0x0400461B RID: 17947
				[FieldOffset(16)]
				public long MatchAnyKeyword;

				// Token: 0x0400461C RID: 17948
				[FieldOffset(24)]
				public long MatchAllKeyword;
			}
		}
	}
}
