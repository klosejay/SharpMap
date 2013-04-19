﻿using System.Collections.Generic;
using GeoAPI.Features;
using GeoAPI.Geometries;
using GeoAPI.SpatialReference;

namespace SharpMap.SpatialReference
{
    /// <summary>
    /// An <see cref="IReprojector"/> implementation, that does not reproject at all
    /// </summary>
    public class NoopReprojector : IReprojectorCore
    {
        public Coordinate Reproject(Coordinate coordinate, ISpatialReference @from, ISpatialReference to)
        {
            return coordinate;
        }

        public Envelope Reproject(Envelope envelope, ISpatialReference @from, ISpatialReference to)
        {
            return envelope;
        }

        public ICoordinateSequence Reproject(ICoordinateSequence sequence, ISpatialReference @from, ISpatialReference to)
        {
            return sequence;
        }
    }
}