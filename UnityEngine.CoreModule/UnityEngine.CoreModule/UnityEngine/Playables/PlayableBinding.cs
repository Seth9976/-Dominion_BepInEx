using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x0200014F RID: 335
	public sealed class PlayableBinding : ValueType
	{
		// Token: 0x06001972 RID: 6514 RVA: 0x0005CE70 File Offset: 0x0005B070
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableBinding()
		{
			Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr);
			PlayableBinding.NativeFieldInfoPtr_m_StreamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_StreamName");
			PlayableBinding.NativeFieldInfoPtr_m_SourceObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_SourceObject");
			PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_SourceBindingType");
			PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "m_CreateOutputMethod");
			PlayableBinding.NativeFieldInfoPtr_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "None");
			PlayableBinding.NativeFieldInfoPtr_DefaultDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "DefaultDuration");
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x0000E20F File Offset: 0x0000C40F
		public PlayableBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x0000E218 File Offset: 0x0000C418
		public PlayableBinding()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr))
		{
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001975 RID: 6517 RVA: 0x0005CF18 File Offset: 0x0005B118
		// (set) Token: 0x06001976 RID: 6518 RVA: 0x0000E22A File Offset: 0x0000C42A
		public unsafe string m_StreamName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_StreamName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_StreamName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001977 RID: 6519 RVA: 0x0005CF40 File Offset: 0x0005B140
		// (set) Token: 0x06001978 RID: 6520 RVA: 0x0000E249 File Offset: 0x0000C449
		public unsafe Object m_SourceObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001979 RID: 6521 RVA: 0x0005CF70 File Offset: 0x0005B170
		// (set) Token: 0x0600197A RID: 6522 RVA: 0x0000E268 File Offset: 0x0000C468
		public unsafe Type m_SourceBindingType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_SourceBindingType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x0005CFA0 File Offset: 0x0005B1A0
		// (set) Token: 0x0600197C RID: 6524 RVA: 0x0000E287 File Offset: 0x0000C487
		public unsafe PlayableBinding.CreateOutputMethod m_CreateOutputMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableBinding.CreateOutputMethod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayableBinding.NativeFieldInfoPtr_m_CreateOutputMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x0005CFD0 File Offset: 0x0005B1D0
		// (set) Token: 0x0600197E RID: 6526 RVA: 0x0000E2A6 File Offset: 0x0000C4A6
		public unsafe static Il2CppReferenceArray<PlayableBinding> None
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayableBinding.NativeFieldInfoPtr_None, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayableBinding>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableBinding.NativeFieldInfoPtr_None, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x0005CFF8 File Offset: 0x0005B1F8
		// (set) Token: 0x06001980 RID: 6528 RVA: 0x0000E2B8 File Offset: 0x0000C4B8
		public unsafe static double DefaultDuration
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(PlayableBinding.NativeFieldInfoPtr_DefaultDuration, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableBinding.NativeFieldInfoPtr_DefaultDuration, (void*)(&value));
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x0005D014 File Offset: 0x0005B214
		// (set) Token: 0x06001982 RID: 6530 RVA: 0x0000E2C6 File Offset: 0x0000C4C6
		public string streamName
		{
			get
			{
				return this.m_StreamName;
			}
			set
			{
				this.m_StreamName = value;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06001983 RID: 6531 RVA: 0x0005D02C File Offset: 0x0005B22C
		// (set) Token: 0x06001984 RID: 6532 RVA: 0x0000E2D0 File Offset: 0x0000C4D0
		public Object sourceObject
		{
			get
			{
				return this.m_SourceObject;
			}
			set
			{
				this.m_SourceObject = value;
			}
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06001985 RID: 6533 RVA: 0x0005D044 File Offset: 0x0005B244
		public Type outputTargetType
		{
			get
			{
				return this.m_SourceBindingType;
			}
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x0005D05C File Offset: 0x0005B25C
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x0000E2DA File Offset: 0x0000C4DA
		public Type sourceBindingType
		{
			get
			{
				return this.m_SourceBindingType;
			}
			set
			{
			}
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x0005D074 File Offset: 0x0005B274
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x0000E2DD File Offset: 0x0000C4DD
		public DataStreamType streamType
		{
			get
			{
				return DataStreamType.None;
			}
			set
			{
			}
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x0005D088 File Offset: 0x0005B288
		public PlayableOutput CreateOutput(PlayableGraph graph)
		{
			bool flag = this.m_CreateOutputMethod != null;
			PlayableOutput playableOutput;
			if (flag)
			{
				playableOutput = this.m_CreateOutputMethod.Invoke(graph, this.m_StreamName);
			}
			else
			{
				playableOutput = PlayableOutput.Null;
			}
			return playableOutput;
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x0005D0C4 File Offset: 0x0005B2C4
		public static PlayableBinding CreateInternal(string name, Object sourceObject, Type sourceType, PlayableBinding.CreateOutputMethod createFunction)
		{
			PlayableBinding playableBinding = null;
			playableBinding.m_StreamName = name;
			playableBinding.m_SourceObject = sourceObject;
			playableBinding.m_SourceBindingType = sourceType;
			playableBinding.m_CreateOutputMethod = createFunction;
			return playableBinding;
		}

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeFieldInfoPtr_m_StreamName;

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceObject;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceBindingType;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeFieldInfoPtr_m_CreateOutputMethod;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeFieldInfoPtr_None;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeFieldInfoPtr_DefaultDuration;

		// Token: 0x020009AE RID: 2478
		public sealed class CreateOutputMethod : MulticastDelegate
		{
			// Token: 0x06003176 RID: 12662 RVA: 0x000177D0 File Offset: 0x000159D0
			// Note: this type is marked as 'beforefieldinit'.
			static CreateOutputMethod()
			{
				Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayableBinding>.NativeClassPtr, "CreateOutputMethod");
				PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr, 100665206);
				PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr, 100665207);
			}

			// Token: 0x06003177 RID: 12663 RVA: 0x0006E628 File Offset: 0x0006C828
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CreateOutputMethod(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayableBinding.CreateOutputMethod>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003178 RID: 12664 RVA: 0x0006E684 File Offset: 0x0006C884
			[CallerCount(0)]
			public unsafe PlayableOutput Invoke(PlayableGraph graph, string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref graph;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableBinding.CreateOutputMethod.NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003179 RID: 12665 RVA: 0x0001780E File Offset: 0x00015A0E
			public CreateOutputMethod(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600317A RID: 12666 RVA: 0x00017817 File Offset: 0x00015A17
			public static implicit operator PlayableBinding.CreateOutputMethod(Func<PlayableGraph, string, PlayableOutput> A_0)
			{
				return DelegateSupport.ConvertDelegate<PlayableBinding.CreateOutputMethod>(A_0);
			}

			// Token: 0x0600317B RID: 12667 RVA: 0x0001781F File Offset: 0x00015A1F
			public static PlayableBinding.CreateOutputMethod operator +(PlayableBinding.CreateOutputMethod A_0, PlayableBinding.CreateOutputMethod A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PlayableBinding.CreateOutputMethod>();
			}

			// Token: 0x0600317C RID: 12668 RVA: 0x0001782D File Offset: 0x00015A2D
			public static PlayableBinding.CreateOutputMethod operator -(PlayableBinding.CreateOutputMethod A_0, PlayableBinding.CreateOutputMethod A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PlayableBinding.CreateOutputMethod>();
				}
				return delegate2;
			}

			// Token: 0x04001D35 RID: 7477
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001D36 RID: 7478
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_PlayableOutput_PlayableGraph_String_0;
		}
	}
}
